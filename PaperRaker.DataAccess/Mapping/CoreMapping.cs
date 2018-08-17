using NPoco;
using NPoco.FluentMappings;
using PaperRaker.Core.Model.System;

namespace PaperRaker.DataAccess.Mapping
{
    public class CoreMapping : Mappings
    {
        public CoreMapping()
        {
            For<Author>().PrimaryKey(x => x.AuthorId)
                .Columns(x =>
                {
                    x.Column(y => y.Isnis).Ignore()
                        .Reference(ReferenceType.Many);
                    x.Column(y => y.Orcids).Ignore()
                        .Reference(ReferenceType.Many);
                    
                    x.Column(y => y.Alias).Ignore()
                        .Reference(ReferenceType.Many);
                });

            For<Institution>().PrimaryKey(x => x.InstitutionId)
                .Columns(x =>
                {
                    x.Column(y => y.Grids).Ignore()
                        .Reference(ReferenceType.Many);
                    x.Column(y => y.Isnis).Ignore()
                        .Reference(ReferenceType.Many);
                    
                    x.Column(y => y.Alias).Ignore()
                        .Reference(ReferenceType.Many);
                });

            For<Publisher>().PrimaryKey(x => x.PublisherId);
            
            For<Paper>().PrimaryKey(x => x.PaperId)
                .Columns(x =>
                {
                    x.Column(y => y.PublisherId).Ignore()
                        .Reference();
                    
                    x.Column(y => y.Contributors).Ignore()
                        .Reference(ReferenceType.Many);
                    x.Column(y => y.Dois).Ignore()
                        .Reference(ReferenceType.Many);
                    x.Column(y => y.Isbns).Ignore()
                        .Reference(ReferenceType.Many);
                    x.Column(y => y.Issns).Ignore()
                        .Reference(ReferenceType.Many);
                    
                    x.Column(y => y.Alias).Ignore()
                        .Reference(ReferenceType.Many);
                });

            For<Contributor>().PrimaryKey("PaperId,AuthorId")
                .Columns(x =>
                {
                    x.Column(y => y.Affiliations)
                        .Reference(ReferenceType.Many);
                });

            For<Affiliation>().PrimaryKey("PaperId,AuthorId,InstitutionId")
                .Columns(x =>
                {
                    x.Column(y => y.InstitutionId)
                        .Reference(ReferenceType.Many);
                });
        }
    }
}