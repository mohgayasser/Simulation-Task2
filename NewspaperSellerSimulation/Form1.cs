using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerTesting;
using NewspaperSellerModels;
using NewspaperSellerSimulation;


namespace NewspaperSellerSimulation
{
    public partial class Form1 : Form
    {
      SimulationSystem sim_system = new SimulationSystem();
   
        NewspaperSellerModels.DayTypeDistribution day_type = new NewspaperSellerModels.DayTypeDistribution();
        List<DayTypeDistribution> day = new List<DayTypeDistribution>();
        List<DayTypeDistribution> DayType = new List<DayTypeDistribution>();
        List<DemandDistribution> Demaaand = new List<DemandDistribution>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Done_Click(object sender, EventArgs e)
        {
            Calculationtable1();
            Calculationtable2();
            ////for (int i = 0; i < day.Count; i++)
            ////{
            ////    MessageBox.Show(day[i].CummProbability.ToString(), day[i].MaxRange.ToString());
            ////}
        }
        private void Calculationtable1()
        {
            sim_system.NumOfNewspapers = Convert.ToInt32(textBox1.Text);
            sim_system.NumOfRecords = Convert.ToInt32(NumOfRecords.Text);
            sim_system.PurchasePrice = decimal.Parse(PurchasePrice.Text);
            sim_system.SellingPrice = decimal.Parse(SellingPrice.Text);
            sim_system.ScrapPrice = decimal.Parse(ScrapPrice.Text);
            sim_system.UnitProfit = sim_system.SellingPrice - sim_system.PurchasePrice;

            decimal new_cumulativeProbability = 0;

           
            for (int i = 0; i < 3; i++)
            {
                //NewspaperSellerModels.DayTypeDistribution day_type = new NewspaperSellerModels.DayTypeDistribution();
                if (i == 0)
                {
                    day_type.DayType = Enums.DayType.Good;
                    day_type.Probability = decimal.Parse(dataGridView1.Rows[0].Cells[i].Value.ToString());
                    day_type.MinRange = Convert.ToInt32(1);

                    new_cumulativeProbability += day_type.Probability;
                    day_type.CummProbability = new_cumulativeProbability;
                    day_type.DayTypeD = "Good";
                    day_type.MaxRange = Convert.ToInt32((new_cumulativeProbability * 100));
                    DayType.Add(day_type);
                }
                else if (i == 1)
                {
                  
                    day_type = new DayTypeDistribution();
                    day_type.DayType = Enums.DayType.Fair;
                    day_type.Probability = decimal.Parse(dataGridView1.Rows[0].Cells[i].Value.ToString());
                    day_type.MinRange = Convert.ToInt32(DayType[0].CummProbability * 100 + 1);

                    new_cumulativeProbability += day_type.Probability;
                    day_type.CummProbability = new_cumulativeProbability;
                    day_type.DayTypeD = "Fair";
                    day_type.MaxRange = Convert.ToInt32((new_cumulativeProbability * 100));
                    DayType.Add(day_type);
                }
                else
                {
                   
                    day_type = new DayTypeDistribution();
                    day_type.DayType = Enums.DayType.Poor;
                    day_type.Probability = decimal.Parse(dataGridView1.Rows[0].Cells[i].Value.ToString());
                    day_type.MinRange = Convert.ToInt32(DayType[1].CummProbability * 100 + 1);
                    day_type.DayTypeD = "Poor";
                    new_cumulativeProbability += day_type.Probability;
                    day_type.CummProbability = new_cumulativeProbability;

                    day_type.MaxRange = Convert.ToInt32((new_cumulativeProbability * 100));
                    DayType.Add(day_type);
                }

                sim_system.DayTypeDistributions = DayType;


            }

        }
        
        private void Calculationtable2()
        {
            //SimulationSystem s = new SimulationSystem();
            DemandDistribution demmand = new DemandDistribution();
            DayTypeDistribution DayGood = new DayTypeDistribution();
            DayTypeDistribution DayFair = new DayTypeDistribution();
            DayTypeDistribution DayPoor = new DayTypeDistribution();



            decimal cummulativeGood = 0;
            decimal cummulativefair = 0;
            decimal cummulativepoor = 0;
            int i = 0;
            foreach (DataGridViewRow row in DemandDistribution.Rows)
            {
                if (row.Cells[0].Value == null) break;
                demmand= new DemandDistribution(); ;
                DayGood = new DayTypeDistribution();
                 DayFair = new DayTypeDistribution();
                 DayPoor = new DayTypeDistribution();
                demmand.Demand = Convert.ToInt32(row.Cells[0].Value);
                
                //GoodDay

                DayGood.Probability = Convert.ToDecimal(row.Cells[1].Value);
                if (i > 0)
                {
                    DayGood.MinRange = Convert.ToInt32(Demaaand[i - 1].DayTypeDistributions[0].CummProbability * 100 + 1);
                    DayGood.CummProbability = DayGood.Probability + Demaaand[i - 1].DayTypeDistributions[0].CummProbability;

                }
                else
                {
                    DayGood.MinRange = 1;
                    DayGood.CummProbability = DayGood.Probability;
                }
                DayGood.DayTypeD = "Good";
                DayGood.MaxRange = Convert.ToInt32(DayGood.CummProbability * 100);
                DayGood.DayType = Enums.DayType.Good;
                demmand.DayTypeDistributions.Add(DayGood);



                //FairDay
                DayFair.Probability = Convert.ToDecimal(row.Cells[2].Value);
           if (DayFair.Probability>0)
                {
                    
                    if (i > 0)
                    {
                        DayFair.MinRange = Convert.ToInt32(Demaaand[i - 1].DayTypeDistributions[1].CummProbability * 100 + 1);
                        DayFair.CummProbability = DayFair.Probability + Demaaand[i - 1].DayTypeDistributions[1].CummProbability;

                    }
                    else
                    {
                        DayFair.MinRange = 1;
                        DayFair.CummProbability = DayFair.Probability;
                    }

                    DayFair.MaxRange = Convert.ToInt32(DayFair.CummProbability * 100);
                    DayFair.DayTypeD = "Fair";
                    DayFair.DayType = Enums.DayType.Fair;
                    demmand.DayTypeDistributions.Add(DayFair);
                    // DayType.Add(DayFair);
                }

                //PoorDay
                
                    DayPoor.Probability = Convert.ToDecimal(row.Cells[3].Value);
                    if (DayPoor.Probability>0)
                {
                    if (i > 0)
                    {
                        DayPoor.MinRange = Convert.ToInt32(Demaaand[i - 1].DayTypeDistributions[2].CummProbability * 100 + 1);
                        DayPoor.CummProbability = DayPoor.Probability + Demaaand[i - 1].DayTypeDistributions[2].CummProbability;

                    }
                    else
                    {
                        DayPoor.MinRange = 1;
                        DayPoor.CummProbability = DayPoor.Probability;
                    }
                    DayPoor.MaxRange = Convert.ToInt32(DayPoor.CummProbability * 100);
                    DayPoor.DayTypeD = "Poor";
                    DayPoor.DayType = Enums.DayType.Poor;
                    demmand.DayTypeDistributions.Add(DayPoor);
                }
                // DayType.Add(DayPoor);
                  Demaaand.Add(demmand);
                //sim_system.DemandDistributions=Demaaand;
                sim_system.DemandDistributions.Add(Demaaand[i]);
                i++;
            }
           
        }


        private void calculateBigTable_Click(object sender, EventArgs e)
        {
            CalculationTable3();
        }




        private void CalculationTable3()
        {
            Random rnd = new Random();
            Random rnd1 = new Random();
            SimulationCase sim;
            //NewspaperSellerModels.SimulationCase sim = new SimulationCase();
            int index = 0;
            decimal TotalDailyNetProfit = 0;
            sim_system.PerformanceMeasures.DaysWithMoreDemand = 0;
            sim_system.PerformanceMeasures.DaysWithUnsoldPapers = 0;
            sim_system.PerformanceMeasures = new PerformanceMeasures();
            for (int i = 0; i < sim_system.NumOfRecords; i++)
            {
                sim = new SimulationCase();
                sim.DailyCost = sim_system.PurchasePrice * sim_system.NumOfNewspapers;
                sim.DayNo = i + 1;
                  sim.RandomNewsDayType = rnd.Next(1, 100);
                for (int j = 0; j < DayType.Count; j++)
                {
                    if (sim.RandomNewsDayType <= DayType[j].MaxRange && sim.RandomNewsDayType >= DayType[j].MinRange)
                    {
                        index = j;
                        if (index == 0)
                        {
                            sim.NewsDayType = Enums.DayType.Good;
                            sim.DayTypeD = "Good";

                        }
                        else if (index == 1)
                        {
                            sim.NewsDayType = Enums.DayType.Fair;
                            sim.DayTypeD = "Fair";
                        }
                        else
                        {
                            sim.NewsDayType = Enums.DayType.Poor;
                            sim.DayTypeD = "Poor";
                        }
                            
                        break;
                    }

                    
                }
                sim.RandomDemand = rnd1.Next(1, 100);
                for (int K = 0; K < Demaaand.Count; K++)
                {
                if (sim.RandomDemand <= Demaaand[K].DayTypeDistributions[index].MaxRange && sim.RandomDemand >= Demaaand[K].DayTypeDistributions[index].MinRange)
                    {
                        sim.Demand = Demaaand[K].Demand;
                        break;
                    }
                }
                //bigtable.Rows.Add(sim.Demand);



                if (sim.Demand <= sim_system.NumOfNewspapers)
                {
                    sim.SalesProfit = (sim.Demand * sim_system.SellingPrice) ;
                }

                else
                    sim.SalesProfit = (sim_system.SellingPrice * sim_system.NumOfNewspapers);

               // bigtable.Rows.Add(sim.SalesProfit);




                if (sim.Demand < sim_system.NumOfNewspapers)
                {
                    sim.ScrapProfit = Math.Abs((sim.Demand - sim_system.NumOfNewspapers)* sim_system.ScrapPrice);
                    sim.LostProfit = 0;
                    //bigtable.Rows.Add(sim.ScrapProfit);
                }

                else
                {
                    sim.ScrapProfit = 0;
                    sim.LostProfit =Math.Abs((  sim_system.NumOfNewspapers - sim.Demand) * (sim_system.UnitProfit));

                   // bigtable.Rows.Add(sim.LostProfit);
                }




                sim.DailyNetProfit =((sim.SalesProfit - sim.DailyCost) - sim.LostProfit )+ sim.ScrapProfit;
                TotalDailyNetProfit += sim.DailyNetProfit;
                sim_system.SimulationTable.Add(sim);
                //bigtable.Rows.Add(sim.DailyNetProfit);

                string[] row = new string[] { sim.DayNo.ToString(),sim.RandomNewsDayType.ToString(),sim.NewsDayType.ToString(),sim.RandomDemand.ToString(),
                sim.Demand.ToString(),sim.SalesProfit.ToString(),sim.LostProfit.ToString(),sim.ScrapProfit.ToString(),sim.DailyNetProfit.ToString()};
                bigtable.Rows.Add(row);


               

                    sim_system.PerformanceMeasures.TotalCost += (sim.DailyCost);
                    sim_system.PerformanceMeasures.TotalLostProfit += (sim.LostProfit);
                    sim_system.PerformanceMeasures.TotalNetProfit += (sim.DailyNetProfit);
                    sim_system.PerformanceMeasures.TotalSalesProfit += (sim.SalesProfit);
                    sim_system.PerformanceMeasures.TotalScrapProfit += (sim.ScrapProfit);

                    if (sim.Demand > sim_system.NumOfNewspapers)
                        sim_system.PerformanceMeasures.DaysWithMoreDemand++;
                    if (sim.Demand < sim_system.NumOfNewspapers)
                        sim_system.PerformanceMeasures.DaysWithUnsoldPapers++;


                
            }

            string testingResult = TestingManager.Test(sim_system, Constants.FileNames.TestCase1);
           // string testingResult = TestingManager.Test(sim_system, Constants.FileNames.TestCase2);
           //string testingResult = TestingManager.Test(sim_system, Constants.FileNames.TestCase3);
            MessageBox.Show(testingResult);

          
        }
        private void showPreformance_Click(object sender, EventArgs e)
        {
            string[] row = new string[] {  sim_system.PerformanceMeasures.TotalSalesProfit.ToString(), sim_system.PerformanceMeasures.TotalCost.ToString(), sim_system.PerformanceMeasures.TotalLostProfit.ToString(), sim_system.PerformanceMeasures.TotalScrapProfit.ToString(),
                 sim_system.PerformanceMeasures.TotalNetProfit.ToString(), sim_system.PerformanceMeasures.DaysWithMoreDemand.ToString(), sim_system.PerformanceMeasures.DaysWithUnsoldPapers.ToString()};
            dataGridView2.Rows.Add(row);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}