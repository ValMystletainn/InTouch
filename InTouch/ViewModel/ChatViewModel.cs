﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InTouch.Model;

namespace InTouch.ViewModel {
    public class ChatRoomViewModel : ViewModelBase {
        private AddressBook.Item _addressInfo;
        private List<Message> _msgList = new List<Message>();
        private int _noReadCount;
        public string id;

        public AddressBook.Item addressInfo {
            get { return _addressInfo; }
            set { SetProperty(ref _addressInfo, value); }
        }

        public List<Message> msgList {
            get { return _msgList; }
            set { SetProperty(ref _msgList, value); }
        }

        public int noReadCount {
            get { return _noReadCount; }
            set { SetProperty(ref _noReadCount, value); }
        }
    }

    public class ChatViewModel : ViewModelBase {
        
        public List<ChatRoomViewModel> chatRoomViewModels { get; set; }

        public ChatRoomViewModel selectedChatRoom;

        public ChatViewModel() {
            chatRoomViewModels = new List<ChatRoomViewModel>();
            foreach (var item in App.addressBook.items) {
                var chatRoomViewModel = new ChatRoomViewModel();
                chatRoomViewModel.addressInfo = item; 
                chatRoomViewModel.id = item.UserName;
                //chatRoomViewModel.msgList = new List<Message>();
                chatRoomViewModels.Add(chatRoomViewModel);
            }
        }
    }


}
