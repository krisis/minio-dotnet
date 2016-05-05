﻿/*
 * Minio .NET Library for Amazon S3 Compatible Cloud Storage, (C) 2015 Minio, Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Minio;
using Minio.Xml;

namespace Minio.Examples
{
    class ListBuckets
    {
        static int Main()
        {
          /// Note: YOUR-ACCESSKEYID and YOUR-SECRETACCESSKEY
          /// are dummy values, please replace them with original values.
            var client = new MinioClient("s3.amazonaws.com", ConfigurationManager.AppSettings["s3AccessKey"],
                                         ConfigurationManager.AppSettings["s3SecretKey"]);

            var buckets = client.ListBuckets();
            foreach (Bucket bucket in buckets)
            {
                Console.Out.WriteLine(bucket.Name + " " + bucket.CreationDateDateTime);
            }

            return 0;
        }
    }
}
