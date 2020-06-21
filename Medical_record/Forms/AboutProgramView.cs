using Medical_record.Data.Models;
using Medical_record.ViewModels;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace Medical_record.Forms
{
    public partial class AboutProgramView : Form
    {
        private readonly AboutPrigrammViewModels _viewModel;

        public AboutProgramView(AboutPrigrammViewModels aboutPrigrammViewModels) 
        {
            InitializeComponent();
            _viewModel = aboutPrigrammViewModels ??
               throw new ArgumentNullException(nameof(aboutPrigrammViewModels));

            //привязка
            _linkLabelGmail.LinkClicked += ButtonLabelGmail_ButtonClick;
            _linkLabelHelp.LinkClicked += ButtonLabelHelp_ButtonClick;

            _textboxHelp.ReadOnly = true;
        }

        /// <summary>
        /// Переход на почту
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLabelGmail_ButtonClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://smurw.developer@gmail.com");
        }

        /// <summary>
        /// Помощь
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLabelHelp_ButtonClick(object sender, EventArgs e)
        {
            if (Width == 380)
            {
                this.Width += 380;
                _linkLabelHelp.Text = "Скрыть";
            }
            else
            {
                this.Width -= 380;
                _linkLabelHelp.Text = "Помощь";
            }
        }

       
    }
}
