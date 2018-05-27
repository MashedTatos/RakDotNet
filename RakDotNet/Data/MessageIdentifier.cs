﻿namespace RakDotNet
{
    public enum MessageIdentifier : byte
    {
        ID_INTERNAL_PING,

        ID_PING,

        ID_PING_OPEN_CONNECTIONS,

        ID_CONNECTED_PONG,

        ID_CONNECTION_REQUEST,

        ID_SECURED_CONNECTION_RESPONSE,

        ID_SECURED_CONNECTION_CONFIRMATION,

        ID_RPC_MAPPING,

        ID_DETECT_LOST_CONNECTIONS,

        ID_OPEN_CONNECTION_REQUEST,

        ID_OPEN_CONNECTION_REPLY,

        ID_RPC,

        ID_RPC_REPLY,

        ID_OUT_OF_BAND_INTERNAL,

        ID_CONNECTION_REQUEST_ACCEPTED,

        ID_CONNECTION_ATTEMPT_FAILED,

        ID_ALREADY_CONNECTED,

        ID_NEW_INCOMING_CONNECTION,

        ID_NO_FREE_INCOMING_CONNECTIONS,

        ID_DISCONNECTION_NOTIFICATION,

        ID_CONNECTION_LOST,

        ID_RSA_PUBLIC_KEY_MISMATCH,

        ID_CONNECTION_BANNED,

        ID_INVALID_PASSWORD,

        ID_MODIFIED_PACKET,

        ID_TIMESTAMP,

        ID_PONG,

        ID_ADVERTISE_SYSTEM,

        ID_REMOTE_DISCONNECTION_NOTIFICATION,

        ID_REMOTE_CONNECTION_LOST,

        ID_REMOTE_NEW_INCOMING_CONNECTION,

        ID_DOWNLOAD_PROGRESS,

        ID_FILE_LIST_TRANSFER_HEADER,

        ID_FILE_LIST_TRANSFER_FILE,

        ID_DDT_DOWNLOAD_REQUEST,

        ID_TRANSPORT_STRING,

        ID_REPLICA_MANAGER_CONSTRUCTION,

        ID_REPLICA_MANAGER_DESTRUCTION,

        ID_REPLICA_MANAGER_SCOPE_CHANGE,

        ID_REPLICA_MANAGER_SERIALIZE,

        ID_REPLICA_MANAGER_DOWNLOAD_STARTED,

        ID_REPLICA_MANAGER_DOWNLOAD_COMPLETE,

        ID_CONNECTION_GRAPH_REQUEST,

        ID_CONNECTION_GRAPH_REPLY,

        ID_CONNECTION_GRAPH_UPDATE,

        ID_CONNECTION_GRAPH_NEW_CONNECTION,

        ID_CONNECTION_GRAPH_CONNECTION_LOST,

        ID_CONNECTION_GRAPH_DISCONNECTION_NOTIFICATION,

        ID_ROUTE_AND_MULTICAST,

        ID_RAKVOICE_OPEN_CHANNEL_REQUEST,

        ID_RAKVOICE_OPEN_CHANNEL_REPLY,

        ID_RAKVOICE_CLOSE_CHANNEL,

        ID_RAKVOICE_DATA,

        ID_AUTOPATCHER_GET_CHANGELIST_SINCE_DATE,

        ID_AUTOPATCHER_CREATION_LIST,

        ID_AUTOPATCHER_DELETION_LIST,

        ID_AUTOPATCHER_GET_PATCH,

        ID_AUTOPATCHER_PATCH_LIST,

        ID_AUTOPATCHER_REPOSITORY_FATAL_ERROR,

        ID_AUTOPATCHER_FINISHED_INTERNAL,

        ID_AUTOPATCHER_FINISHED,

        ID_AUTOPATCHER_RESTART_APPLICATION,

        ID_NAT_PUNCHTHROUGH_REQUEST,

        ID_NAT_TARGET_NOT_CONNECTED,

        ID_NAT_TARGET_CONNECTION_LOST,

        ID_NAT_CONNECT_AT_TIME,

        ID_NAT_SEND_OFFLINE_MESSAGE_AT_TIME,

        ID_NAT_IN_PROGRESS,

        ID_DATABASE_QUERY_REQUEST,

        ID_DATABASE_UPDATE_ROW,

        ID_DATABASE_REMOVE_ROW,

        ID_DATABASE_QUERY_REPLY,

        ID_DATABASE_UNKNOWN_TABLE,

        ID_DATABASE_INCORRECT_PASSWORD,

        ID_READY_EVENT_SET,

        ID_READY_EVENT_UNSET,

        ID_READY_EVENT_ALL_SET,

        ID_READY_EVENT_QUERY,

        ID_LOBBY_GENERAL,

        ID_AUTO_RPC_CALL,

        ID_AUTO_RPC_REMOTE_INDEX,

        ID_AUTO_RPC_UNKNOWN_REMOTE_INDEX,

        ID_RPC_REMOTE_ERROR,

        ID_USER_PACKET_ENUM,
    }
}
