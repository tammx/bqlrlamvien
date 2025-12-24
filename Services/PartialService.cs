using minhlamcons.Models;
using minhlamcons.Models.Database;
using minhlamcons.Models.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace minhlamcons.Services
{
    public class PartialService: IPartialService
    {
        private readonly SiteDbContext _db;
        public PartialService(SiteDbContext db)
        {
            _db = db;
        }
        public List<HeaderViewModel> GetHeader()
        {
            
            var rs = _db.TbPages.Where(x => x.Delete == false && x.ParentId == null && x.IsSidebar==false).OrderBy(x=>x.Order).Select(x=>new HeaderViewModel { Id = x.Id, Name = x.Name, Url = x.Url }).ToList();
            foreach (var item in rs)
            { 
                item.Child = _db.TbPages.Where(x => x.Delete == false && x.ParentId == item.Id && x.IsSidebar == false).OrderBy(x => x.Order).Select(x => new HeaderViewModel { Name = x.Name, Url = x.Url }).ToList();
            }
            return rs;
        }
        
        //public FooterViewModel GetFooter()
        //{
        //    return new FooterViewModel { Email = "abc" };
        //}
        public SliderViewModel GetSlider()
        {
            var slogan = _db.TbSiteSettings.FirstOrDefault(x => !x.Delete && x.Id == SiteSettingCode.SLOGAN).Content;
            ISiteSettingService data = new SiteSettingService(_db);
            List<string> rs = new List<string>();
            List<string> tmp = data.GetBannerImage();
            if (tmp!=null)
                rs = data.GetBannerImage().Where(x => x != "").ToList();
            return new SliderViewModel { LstBanner = rs, Slogan = slogan };
        }
        public List<string> GetSidebar()
        {
            ISiteSettingService data = new SiteSettingService(_db);
            List<string> tmp = data.GetSidebarData();
            if(tmp!=null)
                return tmp.Where(x => x != "").ToList();
            return new List<string>();
        }
        public List<string> GetYoutubeVideo()
        {
            ISiteSettingService data = new SiteSettingService(_db);
            List<string> tmp = data.GetYoutubeVideo();
            if (tmp != null)
                return tmp.Where(x => x != "").ToList();
            return new List<string>();
        }
        public List<string> GetImageGallery()
        {
            ISiteSettingService data = new SiteSettingService(_db);
            List<string> tmp = data.GetImageGallery();
            if (tmp != null)
                return tmp.Where(x => x != "").ToList();
            return new List<string>();
        }
        
    }
}
