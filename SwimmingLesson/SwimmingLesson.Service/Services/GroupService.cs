﻿using SwimmingLesson.Core.InterfaceRepository;
using SwimmingLesson.Core.InterfaceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SwimmingLesson.Service.Services
{
    public class GroupService : IGroupService
    {
        readonly IRepository<Group> _groupRepository;
        readonly IRepositoryManager<Group> _repositoryManager;
        public GroupService(IRepository<Group> groupRepository, IRepositoryManager<Group> repositoryManager)
        {
            _groupRepository = groupRepository;
            _repositoryManager = repositoryManager;
        }

        public bool AddGroup(Group group)
        {
            bool res= _groupRepository.Add(group);
            _repositoryManager.save();
            return res;
        }

        public bool DeleteGroup(int codeGroup)
        {
            return _groupRepository.Delete(codeGroup);
        }

        public Group GetGroupByCode(int codeGroup)
        {
            return _groupRepository.GetByCode(codeGroup);
        }

        public List<Group> GetGroups()
        {
            return _groupRepository.Get();
        }

        public bool UpdateGroup(int groupId, Group group)
        {
            return (_groupRepository.Update(groupId, group));
        }
    }
}
