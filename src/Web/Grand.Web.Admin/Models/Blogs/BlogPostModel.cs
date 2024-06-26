﻿using Grand.Infrastructure.ModelBinding;
using Grand.Infrastructure.Models;
using Grand.Web.Common.Link;
using Grand.Web.Common.Models;
using System.ComponentModel.DataAnnotations;

namespace Grand.Web.Admin.Models.Blogs;

public class BlogPostModel : BaseEntityModel, ILocalizedModel<BlogLocalizedModel>, IStoreLinkModel
{
    [GrandResourceDisplayName("Admin.Content.Blog.BlogPosts.Fields.Title")]
    public string Title { get; set; }

    [UIHint("Picture")]
    [GrandResourceDisplayName("Admin.Content.Blog.BlogPosts.Fields.Picture")]
    public string PictureId { get; set; }

    [GrandResourceDisplayName("Admin.Content.Blog.BlogPosts.Fields.Body")]

    public string Body { get; set; }

    [GrandResourceDisplayName("Admin.Content.Blog.BlogPosts.Fields.BodyOverview")]

    public string BodyOverview { get; set; }

    [GrandResourceDisplayName("Admin.Content.Blog.BlogPosts.Fields.AllowComments")]
    public bool AllowComments { get; set; }

    [GrandResourceDisplayName("Admin.Content.Blog.BlogPosts.Fields.Tags")]

    public string Tags { get; set; }

    [GrandResourceDisplayName("Admin.Content.Blog.BlogPosts.Fields.Comments")]
    public int Comments { get; set; }

    [GrandResourceDisplayName("Admin.Content.Blog.BlogPosts.Fields.CreateDate")]
    [UIHint("DateTime")]
    public DateTime CreateDate { get; set; }

    [GrandResourceDisplayName("Admin.Content.Blog.BlogPosts.Fields.StartDate")]
    [UIHint("DateTimeNullable")]
    public DateTime? StartDate { get; set; }

    [GrandResourceDisplayName("Admin.Content.Blog.BlogPosts.Fields.EndDate")]
    [UIHint("DateTimeNullable")]
    public DateTime? EndDate { get; set; }

    [GrandResourceDisplayName("Admin.Content.Blog.BlogPosts.Fields.MetaKeywords")]

    public string MetaKeywords { get; set; }

    [GrandResourceDisplayName("Admin.Content.Blog.BlogPosts.Fields.MetaDescription")]

    public string MetaDescription { get; set; }

    [GrandResourceDisplayName("Admin.Content.Blog.BlogPosts.Fields.MetaTitle")]

    public string MetaTitle { get; set; }

    [GrandResourceDisplayName("Admin.Content.Blog.BlogPosts.Fields.SeName")]

    public string SeName { get; set; }

    [GrandResourceDisplayName("Admin.Content.Blog.BlogPosts.Fields.CreatedOn")]
    public DateTime CreatedOn { get; set; }

    public IList<BlogLocalizedModel> Locales { get; set; } = new List<BlogLocalizedModel>();

    //Store acl
    [GrandResourceDisplayName("Admin.Content.Blog.BlogPosts.Fields.LimitedToStores")]
    [UIHint("Stores")]
    public string[] Stores { get; set; }
}

public class BlogLocalizedModel : ILocalizedModelLocal, ISlugModelLocal
{
    [GrandResourceDisplayName("Admin.Content.Blog.BlogPosts.Fields.Title")]
    public string Title { get; set; }

    [GrandResourceDisplayName("Admin.Content.Blog.BlogPosts.Fields.BodyOverview")]

    public string BodyOverview { get; set; }

    [GrandResourceDisplayName("Admin.Content.Blog.BlogPosts.Fields.Body")]

    public string Body { get; set; }

    [GrandResourceDisplayName("Admin.Content.Blog.BlogPosts.Fields.MetaKeywords")]

    public string MetaKeywords { get; set; }

    [GrandResourceDisplayName("Admin.Content.Blog.BlogPosts.Fields.MetaDescription")]

    public string MetaDescription { get; set; }

    [GrandResourceDisplayName("Admin.Content.Blog.BlogPosts.Fields.MetaTitle")]

    public string MetaTitle { get; set; }

    public string LanguageId { get; set; }

    [GrandResourceDisplayName("Admin.Content.Blog.BlogPosts.Fields.SeName")]

    public string SeName { get; set; }
}