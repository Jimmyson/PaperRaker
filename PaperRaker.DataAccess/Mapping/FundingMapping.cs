using NPoco.FluentMappings;
using PaperRaker.Core.Model.System;

namespace PaperRaker.DataAccess.Mapping
{
    public class FundingMapping : Mappings
    {
        public FundingMapping()
        {
            /*For<Paper>().PrimaryKey(x => x.Id)
                .Columns(x =>
                {
                    //x.Column(y => y.Id).Ignore();
                    x.Column(y => y.Publisher).Ignore();
                    x.Column(y => y.Contributors).Ignore();
                });

            For<Author>().PrimaryKey(x => x.Id)
                .Columns(x =>
                {
                    x.Column(y => y.Id).Ignore();
                });

            For<Institution>().PrimaryKey(x => x.Id)
                .Columns(x =>
                {
                    x.Column(y => y.Id).Ignore();
                });*/
        }
    }
}