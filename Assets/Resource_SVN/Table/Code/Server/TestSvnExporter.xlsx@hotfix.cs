
//------------------------------------------------------------------------------
// <auto-generated>
//    Genera by BDFramework
// </auto-generated>
//------------------------------------------------------------------------------

namespace Game.Data.Server
{
    using System;
    using System.Collections.Generic;
    using SQLite4Unity3d;
    
    [Serializable()]
    public class TestSvnExporter
    {
        
        /// <summary>
        /// 角色ID
        /// </summary>
        [PrimaryKey]
        public int Id {get;set;}
        /// <summary>
        /// int空
        /// </summary>
        public int i1null {get;set;}
        /// <summary>
        /// int
        /// </summary>
        public int i2 {get;set;}
        /// <summary>
        /// int数组
        /// </summary>
        public int[] i3a {get;set;}
        /// <summary>
        /// int数组空
        /// </summary>
        public int[] i4aNull {get;set;}
        /// <summary>
        /// float空
        /// </summary>
        public float f1null {get;set;}
        /// <summary>
        /// float
        /// </summary>
        public float f2 {get;set;}
        /// <summary>
        /// float数组
        /// </summary>
        public float[] f3a {get;set;}
        /// <summary>
        /// float空数组
        /// </summary>
        public float[] f4aNull {get;set;}
        /// <summary>
        /// double空
        /// </summary>
        public double d1null {get;set;}
        /// <summary>
        /// double
        /// </summary>
        public double d2 {get;set;}
        /// <summary>
        /// double数组
        /// </summary>
        public double[] d3a {get;set;}
        /// <summary>
        /// double空数组
        /// </summary>
        public double[] d4aNull {get;set;}
        /// <summary>
        /// string空
        /// </summary>
        public string s1Null {get;set;}
        /// <summary>
        /// string
        /// </summary>
        public string s2 {get;set;}
        /// <summary>
        /// string数组引号
        /// </summary>
        public string[] s3a1 {get;set;}
        /// <summary>
        /// string数组非引号
        /// </summary>
        public string[] s4 {get;set;}
        /// <summary>
        /// string空数组
        /// </summary>
        public string[] s5anull {get;set;}
    }
}