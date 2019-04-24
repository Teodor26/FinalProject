﻿using FinalProject.BusinessLogic.Dto;
using FinalProject.BusinessLogic.Extensions;
using FinalProject.DataLayer.Repositories;
using FinalProject.EFLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace FinalProjectMVC.Services
{
    public interface IGroupApiService
    {
        Task<List<GroupDto>> Getlist();
        

    }
    public class GroupApiService : IGroupApiService
    {
        private readonly GroupRepository groupRepository
            = new GroupRepository();
        

        public void Delete(int? Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<GroupDto>> Getlist()
        {
            HttpClient client = new HttpClient();

            string apiEndpoint = Properties.Settings.Default.ApiEndpoint;

            client.BaseAddress = new Uri("http://localhost:52470/api/Group");

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var list = groupRepository.GetListOfGroup();

            List<GroupDto> groupList = list.Select(x => x.ToGroupDto()).ToList();

            var response = await client.GetAsync("groupList");

            if (response.IsSuccessStatusCode)
            {
                groupList = await response.Content.ReadAsAsync<List<GroupDto>>();
            }
            return groupList;
        }
    }
}