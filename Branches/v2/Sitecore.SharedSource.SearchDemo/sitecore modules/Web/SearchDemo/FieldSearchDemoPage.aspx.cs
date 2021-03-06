﻿using Sitecore.SharedSource.Searcher;
using Sitecore.SharedSource.Searcher.Parameters;
using System.Collections.Generic;

namespace Sitecore.SharedSource.SearchDemo
{
    public partial class FieldSearchDemoPage : BaseDemoPage
    {

        public override List<SkinnyItem> GetItems(string databaseName,
                                                  string indexName,
                                                  string language,
                                                  string templateFilter,
                                                  string locationFilter,
                                                  string fullTextQuery)
        {
            var searchParam = new FieldSearchParam
            {
                Database = databaseName,
                Language = language,
                FieldName = FieldName.Text,
                FieldValue = FieldValue.Text,
                TemplateIds = templateFilter,
                LocationIds = locationFilter,
                FullTextQuery = fullTextQuery,
                Partial = Partial.Checked
            };

            using (var runner = new QueryRunner(indexName))
            {
                return runner.GetItems(searchParam);
            }
        }
    }
}