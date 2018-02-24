#define DEBUG_MSG


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json.Linq;

namespace AutoUPBit
{
    public partial class AutoUPbit : Form
    {
        private int MAX_GET_DATA_COUNT = 200;

        private string[] CoinNameStrs = new string[] { "BTC", "XRP" };


        public AutoUPbit()
        {
            InitializeComponent();
        }

        private void Init_UI()
        {
#if DEBUG_MSG
            try
            {
#endif 
                this.Reset_UI();

#if DEBUG_MSG   
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Init_UI");
            }
#endif
        }
        private void Init_Variable()
        {
#if DEBUG_MSG
            try
            {
#endif 


#if DEBUG_MSG   
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Init_Variable");
            }
#endif
        }
        private void Reset_UI()
        {
#if DEBUG_MSG
            try
            {
#endif 
                this.UserDateTimePicker.Value = DateTime.Now;
                this.CountNumeric.Value = this.MAX_GET_DATA_COUNT;
                this.CoinNameCheckedListBox.Items.Clear();
                foreach (string tCoinName in this.CoinNameStrs)
                {
                    this.CoinNameCheckedListBox.Items.Add(tCoinName);
                }

                this.ListViewMin1.Items.Clear();
#if DEBUG_MSG   
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Reset_UI");
            }
#endif
        }

        private void AutoUPbit_Load(object sender, EventArgs e)
        {
#if DEBUG_MSG   
            try
            {
#endif 
                this.Init_UI();
                this.Init_Variable();
#if DEBUG_MSG   
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "AutoUPbit_Load");
            }
#endif
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
#if DEBUG_MSG   
            try
            {
#endif 
                if (this.MinuteComboBox.SelectedIndex < 0)
                {
                    //MessageBox.Show("");
                }
                else
                {
                    MessageBox.Show(string.Format("{0}", this.UserDateTimePicker.ToString()));

                    string StrTargetDate, StrTargetTime;

                    DateTime tDateTime = this.UserDateTimePicker.Value;

                    // 2017-12-30
                    StrTargetDate = string.Format("{0:0000}-{1:00}-{2:00}", tDateTime.Year, tDateTime.Month, tDateTime.Day);


                    string MinuteStr = this.MinuteComboBox.SelectedItem.ToString();

                    // minutes, days, weeks, months
                    // Minutes : 1, 3, 5, 10, 15, 30, 60, 240
                    // Market  : KRW, BTC, ETH, USDT
                    // Coin    : BTC, XRP, (etc)
                    // 시세데이터 : 1, 2, 3, 4
                    // 최종시세데이터일시 : 
                    string JsonStr = this.GetChartData(StrTargetDate, MinuteStr, (int)(this.CountNumeric.Value));
                    List<ChartData> data = ChartData.FromJson(JsonStr);

                    int RowIndex = 0;

                    this.ListViewMin1.BeginUpdate();
                    this.ListViewMin1.Items.Clear();
                    foreach (ChartData tChartData in data)
                    {
                        this.ListViewMin1.Items.Add(string.Format("{0:#,0}", RowIndex));
                        this.ListViewMin1.Items[RowIndex].SubItems.Add(tChartData.Code);
                        this.ListViewMin1.Items[RowIndex].SubItems.Add(tChartData.CandleDateTime.ToString());
                        this.ListViewMin1.Items[RowIndex].SubItems.Add(tChartData.CandleDateTimeKst.ToString());
                        this.ListViewMin1.Items[RowIndex].SubItems.Add(string.Format("{0:#,0.000}", tChartData.OpeningPrice));
                        this.ListViewMin1.Items[RowIndex].SubItems.Add(string.Format("{0:#,0.000}", tChartData.HighPrice));
                        this.ListViewMin1.Items[RowIndex].SubItems.Add(string.Format("{0:#,0.000}", tChartData.LowPrice));
                        this.ListViewMin1.Items[RowIndex].SubItems.Add(string.Format("{0:#,0.000}", tChartData.TradePrice));
                        this.ListViewMin1.Items[RowIndex].SubItems.Add(tChartData.CandleAccTradeVolume.ToString());
                        this.ListViewMin1.Items[RowIndex].SubItems.Add(tChartData.CandleAccTradePrice.ToString());
                        this.ListViewMin1.Items[RowIndex].SubItems.Add(tChartData.Timestamp.ToString());
                        this.ListViewMin1.Items[RowIndex].SubItems.Add(tChartData.Unit.ToString());

                        RowIndex += 1;
                    }
                    this.ListViewMin1.EndUpdate();
                }                
#if DEBUG_MSG   
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "");
            }
#endif
        }

        private string GetChartData(string TargetDate, string MinStr, int Count)
        {
            string rst = null;

#if DEBUG_MSG
            try
            {
#endif 
                // minutes, days, weeks, months
                // Minutes : 1, 3, 5, 10, 15, 30, 60, 240
                // Market  : KRW, BTC, ETH, USDT
                // Coin    : BTC, XRP, (etc)
                // 시세데이터 : 1, 2, 3, 4
                // 최종시세데이터일시 (UTC) : 
                // 
                string URL = string.Format("https://crix-api-endpoint.upbit.com/v1/crix/candles/minutes/{0}?code=CRIX.UPBIT.KRW-XRP&count={1}&to={2}%2000:00:00", 
                    MinStr, Count, TargetDate);

                HttpWebRequest tRequest = (HttpWebRequest)WebRequest.Create(URL);
                HttpWebResponse tResponse = (HttpWebResponse)tRequest.GetResponse();
                Stream tStream = tResponse.GetResponseStream();
                StreamReader tReader = new StreamReader(tStream);
                rst = tReader.ReadToEnd();
                tStream.Close();
                tResponse.Close();
#if DEBUG_MSG   
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "GetChartData");
            }
#endif

            return rst;
        }


        private void UpdateChart(string JsonStr)
        {
#if DEBUG_MSG
            try
            {
#endif 

                
#if DEBUG_MSG   
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "");
            }
#endif
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
#if DEBUG_MSG
            try
            {
#endif 
                this.Reset_UI();
#if DEBUG_MSG   
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "ClearBtn_Click");
            }
#endif
        }
    }
}


/*
 #if DEBUG_MSG   
            try
            {
#endif 


#if DEBUG_MSG   
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "");
            }
#endif
*/
