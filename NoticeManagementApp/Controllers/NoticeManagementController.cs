using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NoticeManagementApp.BusinessLayer.Interfaces;
using NoticeManagementApp.BusinessLayer.ViewModels;
using NoticeManagementApp.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using ManagementApp.Entities;

namespace NoticeManagementApp.Controllers
{
    [ApiController]
    public class NoticeManagementController : ControllerBase
    {
        private readonly INoticeManagementService  _noticeService;
        public NoticeManagementController(INoticeManagementService noticeservice)
        {
             _noticeService = noticeservice;
        }

        [HttpPost]
        [Route("create-notice")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateNotice([FromBody] Notice model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpPut]
        [Route("update-notice")]
        public async Task<IActionResult> UpdateNotice([FromBody] NoticeViewModel model)
        {
            //write your code here
            throw new NotImplementedException();
        }

      
        [HttpDelete]
        [Route("delete-notice")]
        public async Task<IActionResult> DeleteNotice(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("get-notice-by-id")]
        public async Task<IActionResult> GetNoticeById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("get-all-notices")]
        public async Task<IEnumerable<Notice>> GetAllNotices()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
