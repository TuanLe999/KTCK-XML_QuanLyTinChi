﻿// ------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
// Runtime Version:4.0.30319.42000
// 
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace KTCK_QuanLySinhVien
{



    /// <summary>
/// Represents a strongly typed in-memory cache of data.
/// </summary>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.ComponentModel.ToolboxItem(true)]
    [System.Xml.Serialization.XmlSchemaProvider("GetTypedDataSetSchema")]
    [System.Xml.Serialization.XmlRoot("dsSinhVien")]
    [System.ComponentModel.Design.HelpKeyword("vs.data.DataSet")]
    public partial class dsSinhVien : DataSet
    {

        private SinhVienDataTable tableSinhVien;

        private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

        [DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public dsSinhVien() : base()
        {
            BeginInit();
            InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = SchemaChanged;
            base.Tables.CollectionChanged += schemaChangedHandler;
            base.Relations.CollectionChanged += schemaChangedHandler;
            EndInit();
        }

        [DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected dsSinhVien(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context, false)
        {
            if (IsBinarySerialized(info, context) == true)
            {
                InitVars(false);
                System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler1 = SchemaChanged;
                Tables.CollectionChanged += schemaChangedHandler1;
                Relations.CollectionChanged += schemaChangedHandler1;
                return;
            }
            string strSchema = Conversions.ToString(info.GetValue("XmlSchema", typeof(string)));
            if (DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
            {
                var ds = new DataSet();
                ds.ReadXmlSchema(new System.Xml.XmlTextReader(new System.IO.StringReader(strSchema)));
                if (ds.Tables["SinhVien"] is not null)
                {
                    base.Tables.Add(new SinhVienDataTable(ds.Tables["SinhVien"]));
                }
                DataSetName = ds.DataSetName;
                Prefix = ds.Prefix;
                Namespace = ds.Namespace;
                Locale = ds.Locale;
                CaseSensitive = ds.CaseSensitive;
                EnforceConstraints = ds.EnforceConstraints;
                Merge(ds, false, MissingSchemaAction.Add);
                InitVars();
            }
            else
            {
                ReadXmlSchema(new System.Xml.XmlTextReader(new System.IO.StringReader(strSchema)));
            }
            GetSerializationData(info, context);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = SchemaChanged;
            base.Tables.CollectionChanged += schemaChangedHandler;
            Relations.CollectionChanged += schemaChangedHandler;
        }

        [DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public SinhVienDataTable SinhVien
        {
            get
            {
                return tableSinhVien;
            }
        }

        [DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [System.ComponentModel.Browsable(true)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public override SchemaSerializationMode SchemaSerializationMode
        {
            get
            {
                return _schemaSerializationMode;
            }
            set
            {
                _schemaSerializationMode = value;
            }
        }

        [DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new DataTableCollection Tables
        {
            get
            {
                return base.Tables;
            }
        }

        [DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new DataRelationCollection Relations
        {
            get
            {
                return base.Relations;
            }
        }

        [DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected override void InitializeDerivedDataSet()
        {
            BeginInit();
            InitClass();
            EndInit();
        }

        [DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public override DataSet Clone()
        {
            dsSinhVien cln = (dsSinhVien)base.Clone();
            cln.InitVars();
            cln.SchemaSerializationMode = SchemaSerializationMode;
            return cln;
        }

        [DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected override bool ShouldSerializeTables()
        {
            return false;
        }

        [DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected override bool ShouldSerializeRelations()
        {
            return false;
        }

        [DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected override void ReadXmlSerializable(System.Xml.XmlReader reader)
        {
            if (DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
            {
                Reset();
                var ds = new DataSet();
                ds.ReadXml(reader);
                if (ds.Tables["SinhVien"] is not null)
                {
                    base.Tables.Add(new SinhVienDataTable(ds.Tables["SinhVien"]));
                }
                DataSetName = ds.DataSetName;
                Prefix = ds.Prefix;
                Namespace = ds.Namespace;
                Locale = ds.Locale;
                CaseSensitive = ds.CaseSensitive;
                EnforceConstraints = ds.EnforceConstraints;
                Merge(ds, false, MissingSchemaAction.Add);
                InitVars();
            }
            else
            {
                ReadXml(reader);
                InitVars();
            }
        }

        [DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected override System.Xml.Schema.XmlSchema GetSchemaSerializable()
        {
            var stream = new System.IO.MemoryStream();
            WriteXmlSchema(new System.Xml.XmlTextWriter(stream, null));
            stream.Position = 0L;
            return System.Xml.Schema.XmlSchema.Read(new System.Xml.XmlTextReader(stream), null);
        }

        [DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        internal void InitVars()
        {
            InitVars(true);
        }

        [DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        internal void InitVars(bool initTable)
        {
            tableSinhVien = (SinhVienDataTable)base.Tables["SinhVien"];
            if (initTable == true)
            {
                if (tableSinhVien is not null)
                {
                    tableSinhVien.InitVars();
                }
            }
        }

        [DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitClass()
        {
            DataSetName = "dsSinhVien";
            Prefix = "";
            Namespace = "http://tempuri.org/dsSinhVien.xsd";
            EnforceConstraints = true;
            SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            tableSinhVien = new SinhVienDataTable();
            base.Tables.Add(tableSinhVien);
        }

        [DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private bool ShouldSerializeSinhVien()
        {
            return false;
        }

        [DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e)
        {
            if (e.Action == System.ComponentModel.CollectionChangeAction.Remove)
            {
                InitVars();
            }
        }

        [DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public static System.Xml.Schema.XmlSchemaComplexType GetTypedDataSetSchema(System.Xml.Schema.XmlSchemaSet xs)
        {
            var ds = new dsSinhVien();
            var type = new System.Xml.Schema.XmlSchemaComplexType();
            var sequence = new System.Xml.Schema.XmlSchemaSequence();
            var any = new System.Xml.Schema.XmlSchemaAny();
            any.Namespace = ds.Namespace;
            sequence.Items.Add(any);
            type.Particle = sequence;
            var dsSchema = ds.GetSchemaSerializable();
            if (xs.Contains(dsSchema.TargetNamespace))
            {
                var s1 = new System.IO.MemoryStream();
                var s2 = new System.IO.MemoryStream();
                try
                {
                    System.Xml.Schema.XmlSchema schema = null;
                    dsSchema.Write(s1);
                    var schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator();
                    while (schemas.MoveNext())
                    {
                        schema = (System.Xml.Schema.XmlSchema)schemas.Current;
                        s2.SetLength(0L);
                        schema.Write(s2);
                        if (s1.Length == s2.Length)
                        {
                            s1.Position = 0L;
                            s2.Position = 0L;

                            while (s1.Position != s1.Length && s1.ReadByte() == s2.ReadByte())
                            {


                            }
                            if (s1.Position == s1.Length)
                            {
                                return type;
                            }
                        }

                    }
                }
                finally
                {
                    if (s1 is not null)
                    {
                        s1.Close();
                    }
                    if (s2 is not null)
                    {
                        s2.Close();
                    }
                }
            }
            xs.Add(dsSchema);
            return type;
        }

        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public delegate void SinhVienRowChangeEventHandler(object sender, SinhVienRowChangeEvent e);

        /// <summary>
    /// Represents the strongly named DataTable class.
    /// </summary>
        [Serializable()]
        [System.Xml.Serialization.XmlSchemaProvider("GetTypedTableSchema")]
        public partial class SinhVienDataTable : TypedTableBase<SinhVienRow>
        {

            private DataColumn columnMSV;

            private DataColumn columnTen;

            private DataColumn columnLop;

            private DataColumn columnGioiTinh;

            private DataColumn columnSDT;

            private DataColumn columnEmail;

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public SinhVienDataTable() : base()
            {
                TableName = "SinhVien";
                BeginInit();
                InitClass();
                EndInit();
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            internal SinhVienDataTable(DataTable table) : base()
            {
                TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() ?? "") != (table.DataSet.Locale.ToString() ?? ""))
                {
                    Locale = table.Locale;
                }
                if ((table.Namespace ?? "") != (table.DataSet.Namespace ?? ""))
                {
                    Namespace = table.Namespace;
                }
                Prefix = table.Prefix;
                MinimumCapacity = table.MinimumCapacity;
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected SinhVienDataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
            {
                InitVars();
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public DataColumn MSVColumn
            {
                get
                {
                    return columnMSV;
                }
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public DataColumn TenColumn
            {
                get
                {
                    return columnTen;
                }
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public DataColumn LopColumn
            {
                get
                {
                    return columnLop;
                }
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public DataColumn GioiTinhColumn
            {
                get
                {
                    return columnGioiTinh;
                }
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public DataColumn SDTColumn
            {
                get
                {
                    return columnSDT;
                }
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public DataColumn EmailColumn
            {
                get
                {
                    return columnEmail;
                }
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            [System.ComponentModel.Browsable(false)]
            public int Count
            {
                get
                {
                    return Rows.Count;
                }
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public SinhVienRow this[int index]
            {
                get
                {
                    return (SinhVienRow)Rows[index];
                }
            }

            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event SinhVienRowChangeEventHandler SinhVienRowChanging;

            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event SinhVienRowChangeEventHandler SinhVienRowChanged;

            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event SinhVienRowChangeEventHandler SinhVienRowDeleting;

            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public event SinhVienRowChangeEventHandler SinhVienRowDeleted;

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void AddSinhVienRow(SinhVienRow row)
            {
                Rows.Add(row);
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public SinhVienRow AddSinhVienRow(string Ten, string Lop, string GioiTinh, string SDT, string Email)
            {
                SinhVienRow rowSinhVienRow = (SinhVienRow)NewRow();
                var columnValuesArray = new object[] { null, Ten, Lop, GioiTinh, SDT, Email };
                rowSinhVienRow.ItemArray = columnValuesArray;
                Rows.Add(rowSinhVienRow);
                return rowSinhVienRow;
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public SinhVienRow FindByMSV(int MSV)
            {
                return (SinhVienRow)Rows.Find(new object[] { MSV });
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public override DataTable Clone()
            {
                SinhVienDataTable cln = (SinhVienDataTable)base.Clone();
                cln.InitVars();
                return cln;
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new SinhVienDataTable();
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            internal void InitVars()
            {
                columnMSV = Columns["MSV"];
                columnTen = Columns["Ten"];
                columnLop = Columns["Lop"];
                columnGioiTinh = Columns["GioiTinh"];
                columnSDT = Columns["SDT"];
                columnEmail = Columns["Email"];
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            private void InitClass()
            {
                columnMSV = new DataColumn("MSV", typeof(int), null, MappingType.Element);
                Columns.Add(columnMSV);
                columnTen = new DataColumn("Ten", typeof(string), null, MappingType.Element);
                Columns.Add(columnTen);
                columnLop = new DataColumn("Lop", typeof(string), null, MappingType.Element);
                Columns.Add(columnLop);
                columnGioiTinh = new DataColumn("GioiTinh", typeof(string), null, MappingType.Element);
                Columns.Add(columnGioiTinh);
                columnSDT = new DataColumn("SDT", typeof(string), null, MappingType.Element);
                Columns.Add(columnSDT);
                columnEmail = new DataColumn("Email", typeof(string), null, MappingType.Element);
                Columns.Add(columnEmail);
                Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] { columnMSV }, true));
                columnMSV.AutoIncrement = true;
                columnMSV.AllowDBNull = false;
                columnMSV.ReadOnly = true;
                columnMSV.Unique = true;
                columnTen.MaxLength = 50;
                columnLop.MaxLength = 50;
                columnGioiTinh.MaxLength = 50;
                columnSDT.MaxLength = 50;
                columnEmail.MaxLength = 50;
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public SinhVienRow NewSinhVienRow()
            {
                return (SinhVienRow)NewRow();
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new SinhVienRow(builder);
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(SinhVienRow);
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (SinhVienRowChanged is not null)
                {
                    SinhVienRowChanged?.Invoke(this, new SinhVienRowChangeEvent((SinhVienRow)e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (SinhVienRowChanging is not null)
                {
                    SinhVienRowChanging?.Invoke(this, new SinhVienRowChangeEvent((SinhVienRow)e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (SinhVienRowDeleted is not null)
                {
                    SinhVienRowDeleted?.Invoke(this, new SinhVienRowChangeEvent((SinhVienRow)e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (SinhVienRowDeleting is not null)
                {
                    SinhVienRowDeleting?.Invoke(this, new SinhVienRowChangeEvent((SinhVienRow)e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void RemoveSinhVienRow(SinhVienRow row)
            {
                Rows.Remove(row);
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public static System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(System.Xml.Schema.XmlSchemaSet xs)
            {
                var type = new System.Xml.Schema.XmlSchemaComplexType();
                var sequence = new System.Xml.Schema.XmlSchemaSequence();
                var ds = new dsSinhVien();
                var any1 = new System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                var any2 = new System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                var attribute1 = new System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                var attribute2 = new System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "SinhVienDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                var dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace))
                {
                    var s1 = new System.IO.MemoryStream();
                    var s2 = new System.IO.MemoryStream();
                    try
                    {
                        System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        var schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator();
                        while (schemas.MoveNext())
                        {
                            schema = (System.Xml.Schema.XmlSchema)schemas.Current;
                            s2.SetLength(0L);
                            schema.Write(s2);
                            if (s1.Length == s2.Length)
                            {
                                s1.Position = 0L;
                                s2.Position = 0L;

                                while (s1.Position != s1.Length && s1.ReadByte() == s2.ReadByte())
                                {


                                }
                                if (s1.Position == s1.Length)
                                {
                                    return type;
                                }
                            }

                        }
                    }
                    finally
                    {
                        if (s1 is not null)
                        {
                            s1.Close();
                        }
                        if (s2 is not null)
                        {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }

        /// <summary>
    /// Represents strongly named DataRow class.
    /// </summary>
        public partial class SinhVienRow : DataRow
        {

            private SinhVienDataTable tableSinhVien;

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            internal SinhVienRow(DataRowBuilder rb) : base(rb)
            {
                tableSinhVien = (SinhVienDataTable)Table;
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public int MSV
            {
                get
                {
                    return Conversions.ToInteger(this[tableSinhVien.MSVColumn]);
                }
                set
                {
                    this[tableSinhVien.MSVColumn] = value;
                }
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public string Ten
            {
                get
                {
                    try
                    {
                        return Conversions.ToString(this[tableSinhVien.TenColumn]);
                    }
                    catch (InvalidCastException e)
                    {
                        throw new StrongTypingException("The value for column 'Ten' in table 'SinhVien' is DBNull.", e);
                    }
                }
                set
                {
                    this[tableSinhVien.TenColumn] = value;
                }
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public string Lop
            {
                get
                {
                    try
                    {
                        return Conversions.ToString(this[tableSinhVien.LopColumn]);
                    }
                    catch (InvalidCastException e)
                    {
                        throw new StrongTypingException("The value for column 'Lop' in table 'SinhVien' is DBNull.", e);
                    }
                }
                set
                {
                    this[tableSinhVien.LopColumn] = value;
                }
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public string GioiTinh
            {
                get
                {
                    try
                    {
                        return Conversions.ToString(this[tableSinhVien.GioiTinhColumn]);
                    }
                    catch (InvalidCastException e)
                    {
                        throw new StrongTypingException("The value for column 'GioiTinh' in table 'SinhVien' is DBNull.", e);
                    }
                }
                set
                {
                    this[tableSinhVien.GioiTinhColumn] = value;
                }
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public string SDT
            {
                get
                {
                    try
                    {
                        return Conversions.ToString(this[tableSinhVien.SDTColumn]);
                    }
                    catch (InvalidCastException e)
                    {
                        throw new StrongTypingException("The value for column 'SDT' in table 'SinhVien' is DBNull.", e);
                    }
                }
                set
                {
                    this[tableSinhVien.SDTColumn] = value;
                }
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public string Email
            {
                get
                {
                    try
                    {
                        return Conversions.ToString(this[tableSinhVien.EmailColumn]);
                    }
                    catch (InvalidCastException e)
                    {
                        throw new StrongTypingException("The value for column 'Email' in table 'SinhVien' is DBNull.", e);
                    }
                }
                set
                {
                    this[tableSinhVien.EmailColumn] = value;
                }
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsTenNull()
            {
                return IsNull(tableSinhVien.TenColumn);
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetTenNull()
            {
                this[tableSinhVien.TenColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsLopNull()
            {
                return IsNull(tableSinhVien.LopColumn);
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetLopNull()
            {
                this[tableSinhVien.LopColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsGioiTinhNull()
            {
                return IsNull(tableSinhVien.GioiTinhColumn);
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetGioiTinhNull()
            {
                this[tableSinhVien.GioiTinhColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsSDTNull()
            {
                return IsNull(tableSinhVien.SDTColumn);
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetSDTNull()
            {
                this[tableSinhVien.SDTColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public bool IsEmailNull()
            {
                return IsNull(tableSinhVien.EmailColumn);
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public void SetEmailNull()
            {
                this[tableSinhVien.EmailColumn] = Convert.DBNull;
            }
        }

        /// <summary>
    /// Row event argument class
    /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public class SinhVienRowChangeEvent : EventArgs
        {

            private SinhVienRow eventRow;

            private DataRowAction eventAction;

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public SinhVienRowChangeEvent(SinhVienRow row, DataRowAction action) : base()
            {
                eventRow = row;
                eventAction = action;
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public SinhVienRow Row
            {
                get
                {
                    return eventRow;
                }
            }

            [DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
            public DataRowAction Action
            {
                get
                {
                    return eventAction;
                }
            }
        }
    }
}