/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NetworkInterface : AbstractModel
    {
        
        /// <summary>
        /// 弹性网卡实例ID，例如：eni-f1xjkw1b。
        /// </summary>
        [JsonProperty("NetworkInterfaceId")]
        public string NetworkInterfaceId{ get; set; }

        /// <summary>
        /// 弹性网卡名称。
        /// </summary>
        [JsonProperty("NetworkInterfaceName")]
        public string NetworkInterfaceName{ get; set; }

        /// <summary>
        /// 弹性网卡描述。
        /// </summary>
        [JsonProperty("NetworkInterfaceDescription")]
        public string NetworkInterfaceDescription{ get; set; }

        /// <summary>
        /// 子网实例ID。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// VPC实例ID。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 绑定的安全组。
        /// </summary>
        [JsonProperty("GroupSet")]
        public string[] GroupSet{ get; set; }

        /// <summary>
        /// 是否是主网卡。
        /// </summary>
        [JsonProperty("Primary")]
        public bool? Primary{ get; set; }

        /// <summary>
        /// MAC地址。
        /// </summary>
        [JsonProperty("MacAddress")]
        public string MacAddress{ get; set; }

        /// <summary>
        /// 取值范围：PENDING|AVAILABLE|ATTACHING|DETACHING|DELETING。
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 内网IP信息。
        /// </summary>
        [JsonProperty("PrivateIpAddressSet")]
        public PrivateIpAddressSpecification[] PrivateIpAddressSet{ get; set; }

        /// <summary>
        /// 绑定的云服务器对象。
        /// </summary>
        [JsonProperty("Attachment")]
        public NetworkInterfaceAttachment Attachment{ get; set; }

        /// <summary>
        /// 可用区。
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NetworkInterfaceId", this.NetworkInterfaceId);
            this.SetParamSimple(map, prefix + "NetworkInterfaceName", this.NetworkInterfaceName);
            this.SetParamSimple(map, prefix + "NetworkInterfaceDescription", this.NetworkInterfaceDescription);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamArraySimple(map, prefix + "GroupSet.", this.GroupSet);
            this.SetParamSimple(map, prefix + "Primary", this.Primary);
            this.SetParamSimple(map, prefix + "MacAddress", this.MacAddress);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamArrayObj(map, prefix + "PrivateIpAddressSet.", this.PrivateIpAddressSet);
            this.SetParamObj(map, prefix + "Attachment.", this.Attachment);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
        }
    }
}

