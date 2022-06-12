﻿using P.Domain.ArticleCategoryAgg;

namespace P.Domain.ArticleAgg;

public class Article
{
    public Article(string title, string shortDescription, string image, long articleCategoryId, string content = "")
    {
        Title = title;
        ShortDescription = shortDescription;
        Image = image;
        Content = content;
        ArticleCategoryId = articleCategoryId;
        CreationDate = DateTime.Now;
        IsDeleted = false;
    }

    protected Article()
    {
    }

    public long Id { get; private set; }
    public string Title { get; private set; }
    public string ShortDescription { get; private set; }
    public string Image { get; private set; }
    public string Content { get; private set; }
    public DateTime CreationDate { get; private set; }
    public bool IsDeleted { get; private set; }
    public long ArticleCategoryId { get; private set; }
    public ArticleCategory ArticleCategory { get; private set; }

    public void Update(string title, string shortDescription, string image, long articleCategoryId,
        string content = "")
    {
        Title = title;
        ShortDescription = shortDescription;
        Image = image;
        Content = content;
        ArticleCategoryId = articleCategoryId;
    }

    public void ChangeState(bool state)
    {
        IsDeleted = state;
    }
}