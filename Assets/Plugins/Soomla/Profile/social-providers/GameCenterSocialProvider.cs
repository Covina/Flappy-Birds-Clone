﻿/// Copyright (C) 2012-2015 Soomla Inc.
///
/// Licensed under the Apache License, Version 2.0 (the "License");
/// you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at
///
///      http://www.apache.org/licenses/LICENSE-2.0
///
/// Unless required by applicable law or agreed to in writing, software
/// distributed under the License is distributed on an "AS IS" BASIS,
/// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
/// See the License for the specific language governing permissions and
/// limitations under the License.
using System;
using UnityEngine;
using System.Collections.Generic;

namespace Soomla.Profile
{
#if UNITY_IOS || UNITY_EDITOR
	public class GameCenterSocialProvider : SocialProvider
	{
		
		public GameCenterSocialProvider () {
			SoomlaProfile.ProviderBecameReady(this);
		}
		
		/// <summary>
		/// See docs in <see cref="SoomlaProfile.UpdateStatus"/>
		/// </summary>
		public override void UpdateStatus(string status, SocialActionSuccess success, SocialActionFailed fail) {}
		
		/// <summary>
		/// See docs in <see cref="SoomlaProfile.UpdateStatusDialog"/>
		/// </summary>
		public override void UpdateStatusDialog(string link, SocialActionSuccess success, SocialActionFailed fail) {}
		
		/// <summary>
		/// See docs in <see cref="SoomlaProfile.UpdateStory"/>
		/// </summary>
		public override void UpdateStory(string message, string name, string caption, string description,
		                                 string link, string pictureUrl, SocialActionSuccess success, SocialActionFailed fail, SocialActionCancel cancel) {}
		
		/// <summary>
		/// See docs in <see cref="SoomlaProfile.UpdateStoryDialog"/>
		/// </summary>
		public override void UpdateStoryDialog(string name, string caption, string description, string link, string picture, 
		                                       SocialActionSuccess success, SocialActionFailed fail, SocialActionCancel cancel) {}
		/// <summary>
		/// See docs in <see cref="SoomlaProfile.UploadImage"/>
		/// </summary>
		public override void UploadImage(byte[] texBytes, string fileName, string message, SocialActionSuccess success, SocialActionFailed fail, SocialActionCancel cancel) {}
		
		/// <summary>
		/// See docs in <see cref="SoomlaProfile.GetContacts"/>
		/// </summary>
		public override void GetContacts(bool fromStart, ContactsSuccess success, ContactsFailed fail) {}
		
		/// <summary>
		/// See docs in <see cref="SoomlaProfile.GetFeed"/>
		/// </summary>
		public override void GetFeed(bool fromStart, FeedSuccess success, FeedFailed fail) {}
		
		/// <summary>
		/// See docs in <see cref="SoomlaProfile.Logout"/>
		/// </summary>
		public override void Logout(LogoutSuccess success, LogoutFailed fail) {}
		
		/// <summary>
		/// See docs in <see cref="SoomlaProfile.Login"/>
		/// </summary>
		public override void Login(LoginSuccess success, LoginFailed fail, LoginCancelled cancel) {}
		
		/// <summary>
		/// See docs in <see cref="SoomlaProfile.GetUserProfile"/>
		/// </summary>
		public override void GetUserProfile(GetUserProfileSuccess success, GetUserProfileFailed fail) {
		}
		
		/// <summary>
		/// See docs in <see cref="SoomlaProfile.IsLoggedIn"/>
		/// </summary>
		public override bool IsLoggedIn() {
			return false;
		}
		
		/// <summary>
		/// See docs in <see cref="SocialProvider.IsAutoLogin"/>
		/// </summary>
		/// <returns>value of autoLogin
		public override bool IsAutoLogin() {
			return false;
		}
		
		/// <summary>
		/// See docs in <see cref="SoomlaProfile.Invite"/>
		/// </summary>
		public override void Invite (string inviteMessage, string dialogTitle, InviteSuccess success, InviteFailed fail, InviteCancelled cancel) {}
		
		/// <summary>
		/// See docs in <see cref="SoomlaProfile.AppRequest"/>
		/// </summary>
		public override void AppRequest(string message, string[] to, string extraData, string dialogTitle, AppRequestSuccess success, AppRequestFailed fail) {}
		
		/// <summary>
		/// See docs in <see cref="SoomlaProfile.Like"/>
		/// </summary>
		public override void Like(string pageId) {}			
		
		public override bool IsNativelyImplemented(){
			return true;
		}
	}
#endif
}


