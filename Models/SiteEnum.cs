using System.ComponentModel;

namespace minhlamcons.Models
{
    public enum PageType
    {
        [Description("")]
        NONE,
        [Description("MinhLam: Dự án")]
        MinhLam_DuAn,
        [Description("MinhLam: Tin tức")]
        MinhLam_TinTuc,
        [Description("MinhLam: Tuyển dụng")]
        MinhLam_TuyenDung,

        [Description("MinhLam: Liên hệ")]
        MinhLam_LienHe,

        [Description("MinhLam: Tin mặc định")]
        MinhLam_TinMacDinh,
        [Description("MinhLam: Thư viện hình ảnh")]
        MinhLam_ImageGallery,
        [Description("MinhLam: Thư viện video")]
        MinhLam_VideoGallery,
    }
    public enum SiteSettingCode
    {
        [Description("Logo")]
        LOGO = 1,
        [Description("Tên công ty")]
        TENCONGTY = 2,
        [Description("Địa chỉ")]
        DIACHI = 3,
        [Description("Số điện thoại")]
        SODIENTHOAI = 4,
        [Description("Email")]
        EMAIL = 5,
        [Description("Facebook")]
        FACEBOOK = 6,
        [Description("Youtube")]
        YOUTUBE = 7,
        [Description("Twitter")]
        TWITTER = 8,
        [Description("Instagram")]
        INSTAGRAM = 9,
        [Description("Zalo")]
        ZALO = 10,
        [Description("Skype")]
        SKYPE = 11,
        [Description("Copyright")]
        COPYRIGHT = 13,
        [Description("Bản đồ")]
        MAP = 14,
        [Description("Mô tả công ty")]
        MOTACONGTY = 15,
        [Description("Fb Messenger")]
        FBMESSENGER = 16,
        [Description("Thông tin khác")]
        THONGTINKHAC = 17,

        [Description("Hình banner trang chủ")]
        SLIDER_1 = 18,
        [Description("Hình sidebar bên phải")]
        SLIDER_2 = 19,
        //[Description("Banner 2")]
        //SLIDER_2 = 19,
        //[Description("Banner 3")]
        //SLIDER_3 = 20,
        //[Description("Banner Nhân sự")]
        //SLIDER_NS = 21,
        //[Description("Banner Đối tác")]
        //SLIDER_DT = 22,
        //[Description("Banner Dự án")]
        //SLIDER_DA = 24,
        //[Description("Banner Tin nội bộ")]
        //SLIDER_TNB = 25,
        //[Description("Banner Tin tức & sự kiện")]
        //SLIDER_TTSK = 26,
        //[Description("Banner Tuyển dụng")]
        //SLIDER_TD = 27,
        [Description("Slider trang chủ (1663 x 600 px)")]
        SLIDER = 28,

        [Description("Trang chủ - Dịch vụ của chúng tôi")]
        //HOME_B1 = 30,
        //[Description("Trang chủ - Tại sao nên lựa chọn")]
        HOME_B2 = 31,
        [Description("Trang chủ - Video")]
        HOME_B3 = 32,
        [Description("Trang chủ - Đối tác")]
        HOME_B4 = 33,
        [Description("Slogan")]
        SLOGAN = 34,
        [Description("Link footer")]
        LINK_FOOTER = 35,
        [Description("Trang chủ - Banner 1")]
        HOME_QC1 = 36,
        [Description("Trang chủ - Banner 2")]
        HOME_QC2 = 37,
        [Description("Trang chủ - Banner 3")]
        HOME_QC3 = 38,

        [Description("Youtube video")]
        YT_VIDEO = 40,
        [Description("Album ảnh")]
        IMG_GALLERY = 41,

        [Description("Sidebar bên phải")]
        SIDEBAR_IMG = 50,
    };
}
