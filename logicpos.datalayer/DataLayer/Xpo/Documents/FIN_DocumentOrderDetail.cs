﻿using DevExpress.Xpo;
using logicpos.datalayer.App;
using System;

namespace logicpos.datalayer.DataLayer.Xpo
{
    [DeferredDeletion(false)]
    public class FIN_DocumentOrderDetail : XPGuidObject
    {
        public FIN_DocumentOrderDetail() : base() { }
        public FIN_DocumentOrderDetail(Session session) : base(session) { }

        protected override void OnAfterConstruction()
        {
            Ord = FrameworkUtils.GetNextTableFieldID(nameof(FIN_DocumentFinanceYearSerieTerminal), "Ord");
            Code = FrameworkUtils.GetNextTableFieldID(nameof(FIN_DocumentFinanceYearSerieTerminal), "Code").ToString();
        }

        UInt32 fOrd;
        public UInt32 Ord
        {
            get { return fOrd; }
            set { SetPropertyValue<UInt32>("Ord", ref fOrd, value); }
        }

        string fCode;
        //[Indexed(Unique = true)] - Can have equal Article.Codes with Diferent Properties
        public string Code
        {
            get { return fCode; }
            set { SetPropertyValue<string>("Code", ref fCode, value); }
        }

        string fDesignation;
        public string Designation
        {
            get { return fDesignation; }
            set { SetPropertyValue<string>("Designation", ref fDesignation, value); }
        }

        Decimal fQuantity;
        public Decimal Quantity
        {
            get { return fQuantity; }
            set { SetPropertyValue<Decimal>("Quantity", ref fQuantity, value); }
        }

        string fUnitMeasure;
        [Size(35)]
        public string UnitMeasure
        {
            get { return fUnitMeasure; }
            set { SetPropertyValue<string>("UnitMeasure", ref fUnitMeasure, value); }
        }

        Decimal fPrice;
        public Decimal Price
        {
            get { return fPrice; }
            set { SetPropertyValue<Decimal>("Price", ref fPrice, value); }
        }

        Decimal fDiscount;
        public Decimal Discount
        {
            get { return fDiscount; }
            set { SetPropertyValue<Decimal>("Discount", ref fDiscount, value); }
        }

        //Decimal fDiscountGlobal;
        //public Decimal DiscountGlobal
        //{
        //  get { return fDiscountGlobal; }
        //  set { SetPropertyValue<Decimal>("DiscountGlobal", ref fDiscountGlobal, value); }
        //}

        Decimal fVat;
        public Decimal Vat
        {
            get { return fVat; }
            set { SetPropertyValue<Decimal>("Vat", ref fVat, value); }
        }

        Guid fVatExemptionReason;
        public Guid VatExemptionReason
        {
            get { return fVatExemptionReason; }
            set { SetPropertyValue<Guid>("VatExemptionReason", ref fVatExemptionReason, value); }
        }

        Decimal fTotalGross;
        public Decimal TotalGross
        {
            get { return fTotalGross; }
            set { SetPropertyValue<Decimal>("TotalGross", ref fTotalGross, value); }
        }

        Decimal fTotalDiscount;
        public Decimal TotalDiscount
        {
            get { return fTotalDiscount; }
            set { SetPropertyValue<Decimal>("TotalDiscount", ref fTotalDiscount, value); }
        }

        Decimal fTotalTax;
        public Decimal TotalTax
        {
            get { return fTotalTax; }
            set { SetPropertyValue<Decimal>("TotalTax", ref fTotalTax, value); }
        }

        Decimal fTotalFinal;
        public Decimal TotalFinal
        {
            get { return fTotalFinal; }
            set { SetPropertyValue<Decimal>("TotalFinal", ref fTotalFinal, value); }
        }

        string fToken1;
        [Size(255)]
        public string Token1
        {
            get { return fToken1; }
            set { SetPropertyValue<string>("Token1", ref fToken1, value); }
        }

        string fToken2;
        [Size(255)]
        public string Token2
        {
            get { return fToken2; }
            set { SetPropertyValue<string>("Token2", ref fToken2, value); }
        }

        //DocumentOrderTicket One <> Many DocumentOrderDetail
        FIN_DocumentOrderTicket fOrderTicket;
        [Association(@"DocumentOrderTicketReferencesDocumentOrderDetail")]
        public FIN_DocumentOrderTicket OrderTicket
        {
            get { return fOrderTicket; }
            set { SetPropertyValue<FIN_DocumentOrderTicket>("OrderTicket", ref fOrderTicket, value); }
        }

        //Article One <> Many DocumentOrderDetail
        FIN_Article fArticle;
        [Association(@"ArticleReferencesDocumentOrderDetail")]
        public FIN_Article Article
        {
            get { return fArticle; }
            set { SetPropertyValue<FIN_Article>("Article", ref fArticle, value); }
        }
    }
}
