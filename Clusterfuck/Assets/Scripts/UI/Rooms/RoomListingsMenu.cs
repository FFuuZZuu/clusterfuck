using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

namespace UI.Rooms
{
    public class RoomListingsMenu : MonoBehaviourPunCallbacks
    {
        [SerializeField] private RoomListing roomListing;
        [SerializeField] private Transform content;

        private List<RoomListing> _listings;

        public override void OnRoomListUpdate(List<RoomInfo> roomList)
        {
            foreach (RoomInfo info in roomList)
            {
                if (info.RemovedFromList)
                {
                    int index = _listings.FindIndex(x => x.RoomInfo.Name == info.Name);
                    if (index != -1)
                    {
                        Destroy(_listings[index].gameObject);
                        _listings.RemoveAt(index);
                    }
                }
                else
                {
                    RoomListing listing = Instantiate(roomListing, content);
                    if (listing != null)
                    {
                        listing.SetRoomInfo(info);
                        _listings.Add(listing);
                    }
                }
            }
        }
    }
}