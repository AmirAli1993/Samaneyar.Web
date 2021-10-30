using Samaneyar.DataLayer.ApplicationDomain;

namespace Samaneyar.DataLayer.Shop.ProductAgg
{
   public class Product:EntityBase
    {
        public string Name { get; private set; }
        public string Title { get; private set; }
        public string Picture { get; private set; }
        public string PictureTitle { get; private set; }
        public string PictureAlt { get; private set; }
        public string Description1 { get; private set; }
        public string Video1 { get; private set; }
        public string Keywords { get; private set; }
        public string Video2 { get; private set; }
        public string VideoTitle { get; private set; }
        public string Description2 { get; private set; }
        public string Description3 { get; private set; }
        public string Slug { get; private set; }
        public string MetaDescription { get; private set; }

        //public string canonicalAddress { get; private set; }
        public ProductCategory.ProductCategory ProductCategory { get; set; }
        public Product(string name, string title, string picture, string pictureTitle, string pictureAlt, string description1, string video1, string keywords, string video2, string videoTitle, string description2, string description3, string slug, string metaDescription)
        {
            Name = name;
            Title = title;
            Picture = picture;
            PictureTitle = pictureTitle;
            PictureAlt = pictureAlt;
            Description1 = description1;
            Video1 = video1;
            Keywords = keywords;
            Video2 = video2;
            VideoTitle = videoTitle;
            Description2 = description2;
            Description3 = description3;
            Slug = slug;
            MetaDescription = metaDescription;
        }

        public void Edit(string name, string title, string picture, string pictureTitle, string pictureAlt, string description1, string video1, string keywords, string video2, string videoTitle, string description2, string description3, string slug, string metaDescription)
        {
            Name = name;
            Title = title;
            Picture = picture;
            PictureTitle = pictureTitle;
            PictureAlt = pictureAlt;
            Description1 = description1;
            Video1 = video1;
            Keywords = keywords;
            Video2 = video2;
            VideoTitle = videoTitle;
            Description2 = description2;
            Description3 = description3;
            Slug = slug;
            MetaDescription = metaDescription;
        }
    }
}
