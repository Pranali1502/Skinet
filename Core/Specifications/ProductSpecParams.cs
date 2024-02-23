namespace Core.Specifications
{
    public class ProductSpecParams
    {
        private const int MaxPageSize= 10;
        private int _pageIndex = 1; // Initialize to 1 by default
        public int PageIndex 
        {
            get => _pageIndex;
            set => _pageIndex = (value > 0) ? value : 1; // Ensure non-zero value
        }
        private int _pageSize=6;
        public int PageSize
        {
            get=> _pageSize;
            set=> _pageSize = (value > MaxPageSize)? MaxPageSize: value;
        }

        public int? BrandId {get; set;}
        public int? TypeId {get; set;}
        public string Sort {get; set;}
        private string _search;
        public string Search 
        {
            get=> _search;
            set=> _search= value.ToLower();
        }
    }
}