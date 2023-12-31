﻿//===========================
// Copyright (c) Tarteeb LLC
// Powering True Leadership
//===========================

using Xeptions;

namespace Excel.Importer.Models.Spreadsheets.Exceptions
{
    public class EmptySpreadsheetException : Xeption
    {
        public EmptySpreadsheetException()
            : base(message: "Spreadsheet is empty")
        { }
    }
}
