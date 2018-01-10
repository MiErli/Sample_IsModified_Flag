using System;
using System.ComponentModel;

namespace T576282
{
    public class SimpleDataSource
    {
        public string Name { get; set; }
        public string Category { get; set; }

        public SimpleDataSource() { }
        public SimpleDataSource(int pInt, int count)
        {
            Name = "Name " + pInt.ToString();
            Category = "String " + (pInt % 4).ToString();
        }

        public static BindingList<SimpleData> GetTestData(int count = 100)
        {
            BindingList<SimpleData> testDataList = new BindingList<SimpleData>();
            for (int i = 0; i < count; i++)
                testDataList.Add(new SimpleData(i, count));

            return testDataList;
        }
        public class SimpleData : SimpleDataSource
        {
            public SimpleData() { }
            public SimpleData(int pInt, int count) : base(pInt, count) { }
        }

        public override string ToString()
        {
            return Category;
        }
    }
}
