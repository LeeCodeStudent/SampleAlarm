using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utils
{
    public class myDataGrid
    {
        public static void AdaptiveWidth(DataGridView dataGridView)
        {
            dataGridView.Columns[0].FillWeight = 5;
            dataGridView.Columns[1].FillWeight = 10;
            dataGridView.Columns[2].FillWeight = 10;
            dataGridView.Columns[3].FillWeight = 5;
            dataGridView.Columns[4].FillWeight = 5;
            dataGridView.Columns[5].FillWeight = 15;
            dataGridView.Columns[6].FillWeight = 7;
            dataGridView.Columns[7].FillWeight = 7;
            dataGridView.Columns[8].FillWeight = 7;
            dataGridView.Columns[9].FillWeight = 7;
            dataGridView.Columns[10].FillWeight = 7;
            dataGridView.Columns[11].FillWeight = 15;
            dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;//换行显示过长文本内容
            dataGridView.ClearSelection();
        }

        public static void AdaptiveWidth_Management(DataGridView dataGridView)
        {
            dataGridView.Columns[0].FillWeight = 20;
            dataGridView.Columns[1].FillWeight = 40;
            dataGridView.Columns[2].FillWeight = 40;
            dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;//换行显示过长文本内容
        }
        public static void AdaptiveWidth_History(DataGridView dataGridView)
        {
            dataGridView.Columns[0].FillWeight = 7;
            dataGridView.Columns[1].FillWeight = 7;
            dataGridView.Columns[2].FillWeight = 14;
            dataGridView.Columns[3].FillWeight = 20;
            dataGridView.Columns[4].FillWeight = 15;
            dataGridView.Columns[5].FillWeight = 10;
            dataGridView.Columns[6].FillWeight = 10;
            dataGridView.Columns[7].FillWeight = 17;
            dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;//换行显示过长文本内容
            dataGridView.ClearSelection();
        }
    }
}
