﻿using System;
using System.Windows.Forms;

namespace 炉边传说
{
    public partial class EffectSelect : Form
    {
        public EffectSelect()
        {
            InitializeComponent();
        }
        public String FirstEffect
        {
            set
            {
                btnEffect1.Text = value;
            }
        }
        public String SecondEffect
        {
            set
            {
                btnEffect2.Text = value;
            }
        }
        /// <summary>
        /// 是否第一效果
        /// </summary>
        public Engine.Utility.CardUtility.抉择枚举 IsFirstEffect =  Engine.Utility.CardUtility.抉择枚举.取消;
        /// <summary>
        /// 第一效果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEffect1_Click(object sender, EventArgs e)
        {
            IsFirstEffect =  Engine.Utility.CardUtility.抉择枚举.第一效果;
            this.Close();
        }
        /// <summary>
        /// 第二效果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEffect2_Click(object sender, EventArgs e)
        {
            IsFirstEffect =  Engine.Utility.CardUtility.抉择枚举.第二效果;
            this.Close();
        }
        /// <summary>
        /// 确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            IsFirstEffect = Engine.Utility.CardUtility.抉择枚举.取消;
            this.Close();
        }
    }
}
