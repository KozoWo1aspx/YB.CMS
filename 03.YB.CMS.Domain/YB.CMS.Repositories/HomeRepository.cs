﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB.CMS.Models.View;
using YB.CMS.IRepositories;
using System.Threading;

namespace YB.CMS.Repositories
{
    public class HomeRepository : Repository<PlatHomeView>, IHomeRepository
    {
        public PlatHomeView PlatHomeModel()
        {
            return QueryDb<PlatHomeView>((context) =>
            {
                //数据库操作
                var home = new PlatHomeView
                {
                    OrderNumber = new LongTrend
                    {
                        TodayNumber = 5263,
                        ContrastNumber = 2365
                    },
                    OrderTotalNumber=new LongTrend {
                        TodayNumber = 5263,
                        ContrastNumber = 105623
                    },
                    SaleAmount = new DecimalTrend
                    {
                        TodayAmount = 1536523.15M,
                        ContrastAmount = 1202365.63M
                    },
                    ShopNumber = new LongTrend
                    {
                        TodayNumber = 0,
                        ContrastNumber = 12
                    },
                    UserNumber = new LongTrend
                    {
                        TodayNumber = 268,
                        ContrastNumber = 1658
                    },
                    OrderLines = FlotChart(6, DateTime.Today),
                    OrderPayLines = FlotChart(6, DateTime.Today)
                };
                return home;
            });
        }

        #region PrivateMethod
        /// <summary>
        /// Flot图标数据集合
        /// </summary>
        /// <param name="days"></param>
        /// <param name="endtime"></param>
        /// <returns></returns>
        private List<long[,]> FlotChart(int days, DateTime? endtime)
        {
            var span = new TimeSpan(DateTime.Parse("1/1/1970").Ticks);
            var dayX = new List<long[,]>();
            for (var i = days; i >= 0; i--)
            {
                var rand = new Random().Next(100, 999);
                dayX.Add(new long[,] { { endtime.Value.AddDays(0 - i).Subtract(span).Ticks / 10000, rand } });
            }
            return dayX;
        }
        #endregion
    }
}
