﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffeeshop
{
    public partial class adminSec : Form
    {
        //Form1 frm = new Form1();
        string sConn = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EMBEDDED\source\repos\coffeeshopApp\coffeeshop\orderListDB.mdf;Integrated Security=True;Connect Timeout=30";

        SqlConnection sqlConnect = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();

        public adminSec()
        {
            InitializeComponent();

            //DB 연결 
            sqlConnect.ConnectionString = sConn;
            sqlConnect.Open();
            sqlCommand.Connection = sqlConnect;
        }

        private void waitingListBtn_Click(object sender, EventArgs e)
        {
            dataGridView_admin.DefaultCellStyle.Font = new Font("D2Coding", 18);
            
            string cmd = "select * from waiting_order_list ";
            //frm.orderListShow(sender, e, cmd, dataGridView_admin);
            orderListShow(sender, e, cmd, dataGridView_admin);

            printTotal();


        }

        private void dataGridView_admin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sub_dataGridView_CellClick(sender, e, dataGridView_admin);

            string cmd = "select * from waiting_order_list";

            orderListShow(sender, e, cmd, dataGridView_admin);
            printTotal();
          
        }


        // 매출 총액 출력 
        public void  printTotal()
        {
            totalSalesBtn.Font = new System.Drawing.Font("D2Coding", 24F);
            //sqlCommand.CommandText = "select sum(it.price*wait.quantity) as total_sales from waiting_order_list wait INNER JOIN item_price it on wait.menu_id = it.menu_id";
            //SqlDataReader rdr2 = sqlCommand.ExecuteReader();
            //int total_sales = 0;
            //while (rdr2.Read())
            //{
            //    total_sales = Convert.ToInt32(rdr2["total_sales"].ToString());
            //}
            //rdr2.Close();

            sqlCommand.CommandText = "select sum(it.price*wait.quantity) as total_price from waiting_order_list wait INNER JOIN item_price it on wait.menu_id= it.menu_id";
            SqlDataReader rdr2 = sqlCommand.ExecuteReader();
            string strPrice = "";

            while (rdr2.Read())
            {
                strPrice += rdr2["total_price"].ToString();
            }
            rdr2.Close();

            totalSalesBtn.Text = $"총 매출 : {strPrice}원"; 

        }

        ArrayList ColName = new ArrayList();
        List<object[]> RunSql(string sql)
        {
            //List<object[]> result = new List<object[]> { };
            List<object[]> result = new List<object[]>();

            sqlCommand.CommandText = sql;

            if (sql.Trim().ToLower().Substring(0, 6) == "select")
            {
                SqlDataReader sr = sqlCommand.ExecuteReader();
                //열의 갯수만큼 반복함 
                ColName.Clear();//이전 sql처리문에 의한 컬럼 정보 삭제 
                for (int i = 0; i < sr.FieldCount; i++)
                {
                    ColName.Add(sr.GetName(i));
                }


                while (sr.Read())
                { //한줄씩 읽어서 처리를 해라 
                    object[] oarr = new object[sr.FieldCount];
                    sr.GetValues(oarr);
                    result.Add(oarr);
                }
                sr.Close();

            }
            else
            {//insert update delete 
                int n = sqlCommand.ExecuteNonQuery();
            }

            //sbLabel3.Text = "Excute OK";
            return result;
        }


        // CART TAB  DATA GRID VIEW 
        public void orderListShow(object sender, EventArgs e, string cmd, DataGridView _gridView)
        {


            /*주문내역 SHOW */
            string sql = cmd;
            List<object[]> result = RunSql(sql);
            if (result == null) return;

            //_gridView.DataSource = null;
            _gridView.Rows.Clear();
            _gridView.Columns.Clear();


            for (int i = 0; i < ColName.Count - 1; i++)
            {
                //추가되는 컬럼의 프로그래밍상 접근 이름, 표시되는 이름 
                //데이터뷰에 컬럼 생성
                string _colName = ColName[i].ToString();
                _gridView.Columns.Add(_colName, _colName);


            }

            //index 7 
            DataGridViewButtonColumn quantityControl = new DataGridViewButtonColumn();
            quantityControl.HeaderText = "차감";
            quantityControl.Text = "-";
            quantityControl.Name = "Sub";
            quantityControl.UseColumnTextForButtonValue = true;
            _gridView.Columns.Add(quantityControl);

            //quantity index 8 
            string colName = ColName[7].ToString();
            _gridView.Columns.Add(colName, colName);

            //+버튼  //index 9 
            DataGridViewButtonColumn quantityControl2 = new DataGridViewButtonColumn();
            //quantityControl.Width =
            quantityControl2.HeaderText = "증감";
            quantityControl2.Text = "+";
            quantityControl2.Name = "Add";
            quantityControl2.UseColumnTextForButtonValue = true;
            _gridView.Columns.Add(quantityControl2);

            //x버튼 //index 10  
            DataGridViewButtonColumn quantityControl3 = new DataGridViewButtonColumn();
           
            quantityControl3.HeaderText = "삭제";
            quantityControl3.Text = "삭제";
            quantityControl3.Name = "Del";
            quantityControl3.UseColumnTextForButtonValue = true;
            _gridView.Columns.Add(quantityControl3);


            //데이터 그리드 row column 크기 조정 불가 
            _gridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            _gridView.AllowUserToResizeColumns = true;
            _gridView.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _gridView.AllowUserToResizeRows = true;
            _gridView.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            _gridView.ReadOnly = true;


            for (int i = 0; i < _gridView.Columns.Count; i++)
            {
                _gridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                _gridView.Columns[i].Resizable = DataGridViewTriState.False;
                _gridView.Columns[i].ReadOnly = true;


                ////메뉴이름 너비 
                //if (i == 0) { _gridView.Columns[i].Width = 300; }
                //else if (i == 4 || i == 6)
                //{ //버튼 위치 너비 
                //    _gridView.Columns[i].Width = 70;
                //}
                //else
                //{//나머지 크기 
                //    _gridView.Columns[i].Width = 150;
                //}
                //_gridView.Columns["price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //그리드 셀 내용 오른쪽 정렬 
                _gridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                _gridView.DefaultCellStyle.Font = new Font("D2Coding", 18);


            }


            for (int i = 0; i < result.Count; i++)
            {
                //sr로부터 i번째 col 의 값을 가져오고 
                int nRow = _gridView.Rows.Add();

                object[] row = result[i];
                for (int j = 0; j < row.Count() - 1; j++)
                {
                    _gridView.Rows[nRow].Cells[j].Value = row[j];

                }
                //quantity 
                _gridView.Rows[nRow].Cells[8].Value = row[7];
            }

        }

        public void sub_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e, DataGridView _gridView)
        {

            // Ignore clicks that are not on button cells. 
            if (e.RowIndex < 0) { return; }

            //+버튼 눌렀을 때 update 
            if (e.ColumnIndex == _gridView.Columns["Add"].Index)
            {//6번 
                Int32 _order_detail_id = (Int32)_gridView[1, e.RowIndex].Value;             

                string quantityAdd = $"update waiting_order_list set quantity=quantity+1 " +
                    $"where order_detail_id={_order_detail_id}";
                sqlCommand.CommandText = quantityAdd;
                sqlCommand.ExecuteNonQuery();

            }//- 버튼 눌렀을 때 update 
            else if (e.ColumnIndex == _gridView.Columns["Sub"].Index)
            {
                int _quantity = (int)_gridView[8, e.RowIndex].Value;
                if (_quantity == 1) { return; }//0으로가면 안됨 
                Int32 _order_detail_id = (Int32)_gridView[1, e.RowIndex].Value;

                string quantityAdd = $"update waiting_order_list set quantity=quantity-1 " +
                    $"where order_detail_id={_order_detail_id}";
                sqlCommand.CommandText = quantityAdd;
                sqlCommand.ExecuteNonQuery();


            }
            else if (e.ColumnIndex == _gridView.Columns["Del"].Index)
            {
                Int32 _order_detail_id = (Int32)_gridView[1, e.RowIndex].Value;

                string quantityDel = $"delete from waiting_order_list where order_detail_id={_order_detail_id}";
                sqlCommand.CommandText = quantityDel;
                sqlCommand.ExecuteNonQuery();

            }

            printTotal();

        }


    }
}