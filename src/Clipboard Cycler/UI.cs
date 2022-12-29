using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clipboard_Cycler
{
    public partial class UI : Form
    {
        public UI() {
            InitializeComponent();
        }

        #region Clipboard List Actions

        private void Add_Click(object sender, EventArgs e) {
            ClipboardList.Items.Add(TextBox.Text);
            TextBox.Text = "";
        }

        private void Clear_Click(object sender, EventArgs e) {
            ClipboardList.Items.Clear();
        }

        private void Remove_Click(object sender, EventArgs e) {
            if (ClipboardList.SelectedIndex >= 0)
                ClipboardList.Items.RemoveAt(ClipboardList.SelectedIndex);
        }


        #endregion

        #region Clipboard Handler

        private static int index = -1;

        #region Keyboard Handler

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private const int WH_KEYBOARD_LL = 13;
        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookId = IntPtr.Zero;

        private void UI_Load(object sender, EventArgs e) {
            _hookId = SetWindowsHookEx(WH_KEYBOARD_LL, _proc, IntPtr.Zero, 0);
        }

        private static Keys lastKey;
        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam) {
            if (nCode >= 0 && wParam == (IntPtr)0x0100 && ToggleStatus.Checked == true) {
                Keys key = (Keys)Marshal.ReadInt32(lParam);
                if (lastKey == Keys.LControlKey && key == Keys.V) {
                    index = index < ClipboardList.Items.Count-1 ? index + 1 : 0;
                    if (ClipboardList.Items.Count >= 1)
                        Clipboard.SetText(ClipboardList.Items[index].ToString());
                }
                else
                    lastKey = key;
            }
            return CallNextHookEx(_hookId, nCode, wParam, lParam);
        }

        #endregion

        #endregion
    }
}
