// <auto-generated>
using System.Reflection;

namespace FxResources.System.Net.WebSockets
{
    internal static class SR { }
}
namespace System
{
    internal static partial class SR
    {
        private static global::System.Resources.ResourceManager s_resourceManager;
        internal static global::System.Resources.ResourceManager ResourceManager => s_resourceManager ?? (s_resourceManager = new global::System.Resources.ResourceManager(typeof(FxResources.System.Net.WebSockets.SR)));

        /// <summary>The WebSocket is in an invalid state ('{0}') for this operation. Valid states are: '{1}'</summary>
        internal static string @net_WebSockets_InvalidState => GetResourceString("net_WebSockets_InvalidState");

        private static string GetResourceString(string x)
        {
            return x;
        }

        /// <summary>An internal WebSocket error occurred. Please see the innerException, if present, for more details.</summary>
        internal static string @net_WebSockets_Generic => GetResourceString("net_WebSockets_Generic");
        /// <summary>The received  message type is invalid after calling {0}. {0} should only be used if no more data is expected from the remote endpoint. Use '{1}' instead to keep being able to receive data but close the output channel.</summary>
        internal static string @net_WebSockets_InvalidMessageType_Generic => GetResourceString("net_WebSockets_InvalidMessageType_Generic");
        /// <summary>An exception caused the WebSocket to enter the Aborted state. Please see the InnerException, if present, for more details.</summary>
        internal static string @net_Websockets_WebSocketBaseFaulted => GetResourceString("net_Websockets_WebSocketBaseFaulted");
        /// <summary>A WebSocket operation was called on a request or response that is not a WebSocket.</summary>
        internal static string @net_WebSockets_NotAWebSocket_Generic => GetResourceString("net_WebSockets_NotAWebSocket_Generic");
        /// <summary>Unsupported WebSocket version.</summary>
        internal static string @net_WebSockets_UnsupportedWebSocketVersion_Generic => GetResourceString("net_WebSockets_UnsupportedWebSocketVersion_Generic");
        /// <summary>The WebSocket request or response operation was called with unsupported protocol(s).</summary>
        internal static string @net_WebSockets_UnsupportedProtocol_Generic => GetResourceString("net_WebSockets_UnsupportedProtocol_Generic");
        /// <summary>The WebSocket request or response contained unsupported header(s).</summary>
        internal static string @net_WebSockets_HeaderError_Generic => GetResourceString("net_WebSockets_HeaderError_Generic");
        /// <summary>The remote party closed the WebSocket connection without completing the close handshake.</summary>
        internal static string @net_WebSockets_ConnectionClosedPrematurely_Generic => GetResourceString("net_WebSockets_ConnectionClosedPrematurely_Generic");
        /// <summary>The WebSocket instance cannot be used for communication because it has been transitioned into an invalid state.</summary>
        internal static string @net_WebSockets_InvalidState_Generic => GetResourceString("net_WebSockets_InvalidState_Generic");
        /// <summary>The argument must be a value greater than {0}.</summary>
        internal static string @net_WebSockets_ArgumentOutOfRange_TooSmall => GetResourceString("net_WebSockets_ArgumentOutOfRange_TooSmall");
        /// <summary>Empty string is not a valid subprotocol value. Please use \"null\" to specify no value.</summary>
        internal static string @net_WebSockets_InvalidEmptySubProtocol => GetResourceString("net_WebSockets_InvalidEmptySubProtocol");
        /// <summary>The WebSocket protocol '{0}' is invalid because it contains the invalid character '{1}'.</summary>
        internal static string @net_WebSockets_InvalidCharInProtocolString => GetResourceString("net_WebSockets_InvalidCharInProtocolString");
        /// <summary>The close status description '{0}' is invalid. When using close status code '{1}' the description must be null.</summary>
        internal static string @net_WebSockets_ReasonNotNull => GetResourceString("net_WebSockets_ReasonNotNull");
        /// <summary>The close status code '{0}' is reserved for system use only and cannot be specified when calling this method.</summary>
        internal static string @net_WebSockets_InvalidCloseStatusCode => GetResourceString("net_WebSockets_InvalidCloseStatusCode");
        /// <summary>The close status description '{0}' is too long. The UTF8-representation of the status description must not be longer than {1} bytes.</summary>
        internal static string @net_WebSockets_InvalidCloseStatusDescription => GetResourceString("net_WebSockets_InvalidCloseStatusDescription");
        /// <summary>The WebSocket protocol is not supported on this platform.</summary>
        internal static string @net_WebSockets_UnsupportedPlatform => GetResourceString("net_WebSockets_UnsupportedPlatform");
        /// <summary>The message type '{0}' is not allowed for the '{1}' operation. Valid message types are: '{2}, {3}'. To close the WebSocket, use the '{4}' operation instead.</summary>
        internal static string @net_WebSockets_Argument_InvalidMessageType => GetResourceString("net_WebSockets_Argument_InvalidMessageType");
        /// <summary>There is already one outstanding '{0}' call for this WebSocket instance. ReceiveAsync and SendAsync can be called simultaneously, but at most one outstanding operation for each of them is allowed at the same time.</summary>
        internal static string @net_Websockets_AlreadyOneOutstandingOperation => GetResourceString("net_Websockets_AlreadyOneOutstandingOperation");
        /// <summary>The WebSocket received a frame with one or more reserved bits set.</summary>
        internal static string @net_Websockets_ReservedBitsSet => GetResourceString("net_Websockets_ReservedBitsSet");
        /// <summary>The WebSocket server sent a masked frame.</summary>
        internal static string @net_Websockets_ClientReceivedMaskedFrame => GetResourceString("net_Websockets_ClientReceivedMaskedFrame");
        /// <summary>The WebSocket received a continuation frame from a previous final message.</summary>
        internal static string @net_Websockets_ContinuationFromFinalFrame => GetResourceString("net_Websockets_ContinuationFromFinalFrame");
        /// <summary>The WebSocket expected a continuation frame after having received a previous non-final frame.</summary>
        internal static string @net_Websockets_NonContinuationAfterNonFinalFrame => GetResourceString("net_Websockets_NonContinuationAfterNonFinalFrame");
        /// <summary>The WebSocket received an invalid control message.</summary>
        internal static string @net_Websockets_InvalidControlMessage => GetResourceString("net_Websockets_InvalidControlMessage");
        /// <summary>The WebSocket received a frame with an unknown opcode: '0x{0}'.</summary>
        internal static string @net_Websockets_UnknownOpcode => GetResourceString("net_Websockets_UnknownOpcode");
        /// <summary>The base stream is not readable.</summary>
        internal static string @NotReadableStream => GetResourceString("NotReadableStream");
        /// <summary>The base stream is not writeable.</summary>
        internal static string @NotWriteableStream => GetResourceString("NotWriteableStream");
        /// <summary>The WebSocket received a frame with an invalid payload length.</summary>
        internal static string @net_Websockets_InvalidPayloadLength => GetResourceString("net_Websockets_InvalidPayloadLength");

    }
}