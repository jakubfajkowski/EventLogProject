﻿using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EventLogProject {
    public class FilteredTextBox : TextBox {
        public static string RemoveSpecialCharacters(string str) {
            return Regex.Replace(str, "[^a-zA-Z0-9_.]+", "", RegexOptions.Compiled);
        }

        protected override void OnTextChanged(EventArgs e) {
            base.OnTextChanged(e);
            Text = RemoveSpecialCharacters(Text);
            SelectionStart = TextLength;
        }
    }
}
