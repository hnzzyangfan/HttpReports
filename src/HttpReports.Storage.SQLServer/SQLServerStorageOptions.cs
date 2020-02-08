﻿using Microsoft.Extensions.Options;
using System;

namespace HttpReports.Storage.SQLServer
{
    internal class SQLServerStorageOptions : IOptions<SQLServerStorageOptions>
    {
        public string ConnectionString { get; set; }

        /// <summary>
        /// 是否启用延时写入
        /// </summary>
        public bool EnableDefer { get; set; }

        /// <summary>
        /// 延时时间
        /// </summary>
        public TimeSpan DeferTime { get; set; }

        /// <summary>
        /// 延时阈值
        /// </summary>
        public int DeferThreshold { get; set; }

        public SQLServerStorageOptions Value => this;
    }
}