using NPoco.FluentMappings;
using PaperRaker.Core.Model.System;

namespace PaperRaker.DataAccess.Mapping
{
    public class CoreMapping : Mappings
    {
        public CoreMapping()
        {
            For<Paper>().PrimaryKey(x => x.Id)
                .Columns(x =>
                {
                    x.Column(y => y.Publisher).Ignore();
                    x.Column(y => y.Contributors).Ignore();
                });

            For<Author>().PrimaryKey(x => x.Id)
                .Columns(x =>
                {
                });

            For<Institution>().PrimaryKey(x => x.Id)
                .Columns(x =>
                {
                });
        }
    }
}