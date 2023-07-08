using DocumentFormat.OpenXml;
using System;
using System.Collections.Generic;

namespace GoogleSheetsWrapper.Tests.TestObjects
{
    public class TestRecord : BaseRecord
    {



        [SheetField(
            DisplayName = "symbol",
            ColumnID = 1,
            FieldType = SheetFieldType.String)]
        public string? symbol { get; set; }


        [SheetField(
            DisplayName = "id",
            ColumnID = 2,
            FieldType = SheetFieldType.Integer)]
        public int? id { get; set; }



        [SheetField(
            DisplayName = "orderId",
            ColumnID = 3,
            FieldType = SheetFieldType.Integer)]
        public int? orderId { get; set; }


        [SheetField(
            DisplayName = "price",
            ColumnID = 4,
            FieldType = SheetFieldType.Number)]
        public decimal? price { get; set; }

        [SheetField(
            DisplayName = "qty",
            ColumnID = 5,
            FieldType = SheetFieldType.Number)]
        public decimal? qty { get; set; }


        [SheetField(
            DisplayName = "quoteQty",
            ColumnID = 6,
            FieldType = SheetFieldType.Number)]
        public decimal? quoteQty { get; set; }

        [SheetField(
            DisplayName = "comission",
            ColumnID = 7,
            FieldType = SheetFieldType.Number)]
        public decimal? comission { get; set; }


        [SheetField(
            DisplayName = "comissionAsset",
            ColumnID = 8,       
            FieldType = SheetFieldType.Number)]
        public string? comissionAsset { get; set; }



        [SheetField(
            DisplayName = "time",
            ColumnID = 9,
            FieldType = SheetFieldType.DateTime)]
        public decimal? time { get; set; }



        public TestRecord()
        {


        }




        public TestRecord(IList<object> row, int rowId, int minColumnId = 1)
            : base(row, rowId, minColumnId)
        {


        }
    }
}
