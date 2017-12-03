using System.Collections.Generic;
using System.Web.Mvc;
using BussinessLayer.DTO;
using BussinessLayer.Filters;


namespace Web.Models
{
    public class AppUserViewModel
    {
        //public string[] ProductSortCriteria => new[] { nameof(ProductDto.Name), nameof(ProductDto.Price), nameof(ProductDto.DiscountPercentage) };

        //public IList<CategoryDto> Categories { get; set; }

        public IList<AppUserDTO> Products { get; set; }

        public AppUserFilterDto Filter { get; set; }

        //public SelectList AllSortCriteria => new SelectList(ProductSortCriteria);
    }
}