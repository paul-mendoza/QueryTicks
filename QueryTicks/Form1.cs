using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.ConversionServices;

namespace QueryTicks
{
    public partial class Form1 : Form
    {
        private readonly string queryFromMask = "(PartitionKey ge '0{0}')";
        private readonly string querySpanMask = "(PartitionKey ge '0{0}' and PartitionKey le '0{1}')";
        public Form1()
        {
            InitializeComponent();
            dateTimePickerFrom.Format = DateTimePickerFormat.Custom;
            dateTimePickerFrom.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            dateTimePickerFrom.Value = DateTime.Today;

            dateTimePickerTo.Format = DateTimePickerFormat.Custom;
            dateTimePickerTo.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            dateTimePickerFrom.Value = DateTime.Today;

            queryFrom.Text = string.Format(queryFromMask, dateTimePickerFrom.Value.Ticks);
            querySpan.Text = string.Format(querySpanMask, dateTimePickerFrom.Value.Ticks, dateTimePickerTo.Value.Ticks);
            hourSpan.Text = string.Format(querySpanMask, dateTimePickerFrom.Value.Ticks, dateTimePickerFrom.Value.Ticks);
        }

        private void copyFrom_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(queryFrom.Text);
        }

        private void copySpan_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(querySpan.Text);
        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            queryFrom.Text = string.Format(queryFromMask, dateTimePickerFrom.Value.Ticks);
            querySpan.Text = string.Format(querySpanMask, dateTimePickerFrom.Value.Ticks, dateTimePickerTo.Value.Ticks);
            hourSpan.Text = string.Format(querySpanMask, dateTimePickerFrom.Value.Ticks, dateTimePickerFrom.Value.Ticks);
        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            querySpan.Text = string.Format(querySpanMask, dateTimePickerFrom.Value.Ticks, dateTimePickerTo.Value.Ticks);
        }

        private void addHourSpan_ValueChanged(object sender, EventArgs e)
        {
            hourSpan.Text = string.Format(querySpanMask, dateTimePickerFrom.Value.Ticks, dateTimePickerFrom.Value.Ticks);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
