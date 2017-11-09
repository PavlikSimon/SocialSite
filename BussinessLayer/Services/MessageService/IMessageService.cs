using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.DTO;
using BussinessLayer.Filters;
using BussinessLayer.QueryObjects.Common;

namespace BussinessLayer.Services.GroupService
{
    public interface IMessageService
    {
 
        
        /// <summary>
        /// Gets all DTOs (for given type)
        /// </summary>
        /// <returns>all available dtos (for given type)</returns>
        Task<QueryResultDto<MessageDTO, MessageFilterDto>> ListAllAsync();


       // void createFriendship(AppUserDTO user1, AppUserDTO user2);
    }
}