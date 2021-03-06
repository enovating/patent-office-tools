// -------------------------------------------------------------------------------------
// This file is part of 'Patent Office Tools' source code.
// 
// Patent Office Tools is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but without any warranty; without even the implied warranty of
// merchantability or fitness for a particular purpose. See the
// GNU Affero General Public License for more details.
// 
// Copyright 2019-2020 enovating SA <https://www.enovating.com/>
// -------------------------------------------------------------------------------------

namespace enovating.POT.MSW.Providers.OPS.Models
{
    using System.Xml.Serialization;

    /// <summary>
    ///     OPS: WORLD PATENT DATA
    /// </summary>
    [XmlRoot("world-patent-data", Namespace = OPSConstants.XML.OPS)]
    public class WPD
    {
        [XmlArray("exchange-documents", Namespace = OPSConstants.XML.Exchange)]
        [XmlArrayItem("exchange-document", Namespace = OPSConstants.XML.Exchange)]
        public ExchangeDocument[] ExchangeDocuments { get; set; }

        [XmlElement("patent-family", Namespace = OPSConstants.XML.OPS)]
        public PatentFamily PatentFamily { get; set; }
    }
}
