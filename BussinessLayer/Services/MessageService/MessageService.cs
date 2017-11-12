using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DAL.Repositories;
using Riganti.Utils.Infrastructure.Core;
using BussinessLayer.DTO;
using BussinessLayer.Filters;
using BussinessLayer.QueryObjects;
using BussinessLayer.Services.GroupService;
using DAL;
using DAL.Entities;
using DAL.IdentityEntities;

namespace BussinessLayer.Services.MessageService
{
    public class MessageService : CRUDBase<Message, MessageDTO, MessageFilterDto>, IMessageService
    {
        public MessageService(IMapper mapper, IRepository<Message, int> messageRepository, MessageQueryObject messageQueryObject, IRepository<AppUser, int> userRepository)
            : base(mapper, messageRepository, messageQueryObject)
        {
            _userRepository = userRepository;
        }


        private readonly IRepository<AppUser, int> _userRepository;

        protected override async Task<Message> GetWithIncludesAsync(int entityId)
        {
            return await Repository.GetByIdAsync(entityId);
        }

        public void SendMessage(AppUserDTO from, AppUserDTO to, MessageDTO message)
        {
            AppUser repFrom = Mapper.Map<AppUserDTO, AppUser>(from);
            AppUser repTo = Mapper.Map<AppUserDTO, AppUser>(to);
            this.Create(message);
            Message repMessage = Mapper.Map<MessageDTO, Message>(message);
            repFrom.SentMessages.Add(repMessage);
            repTo.ReceivedMessages.Add(repMessage);
            repMessage.Receiver = repTo;
            repMessage.Receiver = repFrom;
            Repository.Update(repMessage);
            _userRepository.Update(repFrom);
            _userRepository.Update(repTo);

        }
 


    }
}
