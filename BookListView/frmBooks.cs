using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookListView
{
    public partial class frmBooks : Form
    {

        string[] b_name = { "木馬屠城記", "格列佛遊記", "天方夜譚", "圓桌武士", "孤星淚", "老人與海", "基度山恩仇記", "動物農莊", "白鯨記", "鐘樓怪人", "雙城記", "傲慢與偏見", "金銀島" }; //書名

        string[] author = { "荷馬", "喬納森．斯威夫特", "佚名", "馬洛禮", "雨果", "海明威", "大仲馬", "喬治．歐威爾", "赫爾曼．梅爾維爾", "雨果", "狄更斯", "珍．奧斯汀", "史蒂文生" }; //作者

        string[] kind = { "史詩文學", "奇幻冒險", "民間故事", "騎士文學", "歷史小說", "文學小說", "復仇小說", "政治寓言", "海洋冒險", "哥德小說", "歷史小說", "愛情小說", "尋寶冒險" }; //類別


        public frmBooks()
        {
            InitializeComponent();
        }

        private void frmBooks_Load(object sender, EventArgs e)
        {
            cmbView.Items.Add("大圖示");
            cmbView.Items.Add("詳細資料");
            cmbView.Items.Add("小圖示");
            cmbView.Items.Add("清單");
            cmbView.Items.Add("大圖示加詳細資料");
            cmbView.SelectedIndex = 0; //預設選取第一個項目
            lvwBooks.Columns.Add("書名", 140); //新增 書名 欄位，寬度為140
            lvwBooks.Columns.Add("作者", 170); //新增 作者 欄位，寬度為170
            lvwBooks.Columns.Add("類別", 100); //新增 類別 欄位
            lvwBooks.BeginUpdate(); //暫停重繪
            for (int i = 0; i < b_name.Length; i++)
            { //宣告一個ListViewItem物件
                ListViewItem lvi = new ListViewItem(b_name[i]);
                lvi.SubItems.Add(author[i].ToString()); //新增 作者 欄位資料
                lvi.SubItems.Add(kind[i]); //新增 類別 欄位資料
                lvwBooks.Items.Add(lvi); //新增項目
                lvwBooks.Items[i].ImageIndex = i; //指定影像的索引值
            }
            lvwBooks.EndUpdate(); //恢復重繪
        }

        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //根據cmbView的SelectedIndex屬性值，設定檢視方式
            switch (cmbView.SelectedIndex)
            {
                case 0: //大圖示
                    lvwBooks.View = View.LargeIcon;
                    break;
                case 1: //詳細資料
                    lvwBooks.View = View.Details;
                    break;
                case 2: //小圖示
                    lvwBooks.View = View.SmallIcon;
                    break;
                case 3: //清單
                    lvwBooks.View = View.List;
                    break;
                case 4: //大圖示加詳細資料
                    lvwBooks.View = View.Tile;
                    break;
            }
         }

        private void lvwBooks_ItemActivate(object sender, EventArgs e)
        {
            //取得書名
            string strBookname = b_name[lvwBooks.SelectedIndices[0]];
            //判斷選取的書名是否在選取清單中
            bool exist = lstBorrow.Items.Contains(strBookname);
            if (!exist) // 若選取的書名不存在借書清單中
            {
                DialogResult dr = MessageBox.Show("確定要借閱嗎?", strBookname, MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes) // 若按 <是> 鈕
                { // 新增項目到借書清單
                    lstBorrow.Items.Add(strBookname);
                }
            }   
        }
        private void lstBorrow_DoubleClick(object sender, EventArgs e)
        {
            if (lstBorrow.SelectedIndex == -1)
                return;

            string book = lstBorrow.SelectedItem.ToString();

            DialogResult dr = MessageBox.Show(
                "確定要歸還嗎?",
                book,
                MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                lstBorrow.Items.Remove(book);
            }
        }
    }
}
