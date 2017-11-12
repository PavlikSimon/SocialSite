using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.DTO;
using BussinessLayer.Facades.Common;
using BussinessLayer.Filters;
using BussinessLayer.QueryObjects.Common;
using BussinessLayer.Services.AppUserService;
using BussinessLayer.Services.CommentService;
using BussinessLayer.Services.GroupService;
using BussinessLayer.Services.StatusService;
using Riganti.Utils.Infrastructure.Core;


namespace BussinessLayer.Facades
{
    public class MessageFacade : FacadeBase
    {
        private readonly IMessageService messageService;

        public MessageFacade(IUnitOfWorkProvider unitOfWorkProvider, IMessageService messageService) : base(unitOfWorkProvider)
        {
            this.messageService = messageService;
        }



        public int Create(MessageDTO entityDto)
        {
            int returnValue;
            using (UnitOfWorkProvider.Create())
            {
                returnValue = messageService.Create(entityDto);
            }
            return returnValue;
        }

        public void Update(MessageDTO entityDto)
        {
            using (UnitOfWorkProvider.Create())
            {
                messageService.Update(entityDto);
            }
        }

        public void Delete(MessageDTO entityDto)
        {
            using (UnitOfWorkProvider.Create())
            {
                messageService.Delete(entityDto.Id);
            }
        }

        public async Task<MessageDTO> GetByIdAsync(int entityId)
        {
            return await messageService.GetAsync(entityId);
        }

        public IEnumerable<MessageDTO> ListAll()
        {
            return messageService.ListAllAsync().Result.Items;
        }

    }
}
