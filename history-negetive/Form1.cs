using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace history_negetive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBeginDateMonth.Tag = "Begin";
            comboBeginDateYear.Tag  = "Begin";
            comboEndDateMonth.Tag   = "End";
            comboEndDateYear.Tag    = "End";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Definition of months
            string[] months =
            {
                "January"  ,   "February",  "March"   ,    "April" ,
                "May"      ,   "June"    ,  "July"    ,    "August",
                "September",   "October" ,  "November",    "December"
            };

            //Fill combo boxes with months
            for (int i = 0; i < 12; i++)
            {
                comboBeginDateMonth.Items.Add(months[i]);
                comboEndDateMonth.Items.Add(months[i]);
            }

            //Default January
            comboBeginDateMonth.SelectedIndex = 0;
            comboEndDateMonth.SelectedIndex = 0;

            //Fill combo boxes with years
            for (int i = 0; i <=DateTime.Now.Year; i++)
            {
                comboBeginDateYear.Items.Add(String.Format("{0:0000}", i));
                comboEndDateYear.Items.Add(String.Format("{0:0000}", i));
            }

            //Put default year on 2000
            comboBeginDateYear.SelectedIndex = 1999;
            comboEndDateYear.SelectedIndex = 1999;

            //Fill combo boxes for days
            FillDays(comboBeginDateDay, "Begin");
            FillDays(comboEndDateDay, "End");

            //Add event controller
            comboBeginDateMonth.SelectedIndexChanged += new EventHandler(RecalculateDays);
            comboBeginDateYear.SelectedIndexChanged  += new EventHandler(RecalculateDays);
            comboEndDateMonth.SelectedIndexChanged   += new EventHandler(RecalculateDays);
            comboEndDateDay.SelectedIndexChanged     += new EventHandler(RecalculateDays);
        }
        private void FillDays(ComboBox comboBox, string tag)
        {
            int selectedMonth;
            int selectedYear;

            if (tag == "Begin") 
            {
                selectedMonth = comboBeginDateMonth.SelectedIndex + 1;
                selectedYear  = comboBeginDateYear.SelectedIndex + 1;
            }
            else
            {
                selectedMonth = comboEndDateMonth.SelectedIndex + 1;
                selectedYear  = comboEndDateYear.SelectedIndex + 1;
            }

            int maxDay = DateTime.DaysInMonth(selectedYear, selectedMonth);

            comboBox.Items.Clear();

            for (int i = 0; i <= maxDay; i++)
            {
                comboBox.Items.Add(i);
            }

            comboBox.SelectedIndex = 0;
        }
        private void RecalculateDays(object sender, EventArgs e)
        {
            if ((sender as ComboBox).Tag.ToString() == "Begin")
            {
                FillDays(comboBeginDateDay, "Begin");
            }
            else
            {
                FillDays(comboEndDateDay, "end");
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            DateTime beginDate = new DateTime
                (
                comboBeginDateYear.SelectedIndex + 1,
                comboBeginDateMonth.SelectedIndex + 1,
                comboBeginDateDay.SelectedIndex + 1
                );

            DateTime endDate = new DateTime
                (
                comboEndDateDay.SelectedIndex + 1,
                comboEndDateMonth.SelectedIndex + 1,
                comboEndDateYear.SelectedIndex + 1
                );

            TimeSpan difference = endDate.Subtract(beginDate);

            labelResult.Text = string.Format("{0} Days", difference.Days);
        }
    }
}
