/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the ivs-2020-07-14.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.IVS.Model;

namespace Amazon.IVS
{
    /// <summary>
    /// Interface for accessing IVS
    ///
    /// <b>Introduction</b> 
    /// 
    ///  
    /// <para>
    /// The Amazon Interactive Video Service (IVS) API is REST compatible, using a standard
    /// HTTP API and an <a href="http://aws.amazon.com/sns">AWS SNS</a> event stream for responses.
    /// JSON is used for both requests and responses, including errors.
    /// </para>
    ///  
    /// <para>
    /// The API is an AWS regional service, currently in these regions: us-west-2, us-east-2,
    /// and eu-west-1.
    /// </para>
    ///  
    /// <para>
    ///  <i> <b>All API request parameters and URLs are case sensitive. </b> </i> 
    /// </para>
    ///  
    /// <para>
    /// For a summary of notable documentation changes in each release, see <a href="https://docs.aws.amazon.com/ivs/latest/userguide/doc-history.html">
    /// Document History</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Allowed Header Values</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code> <b>Accept:</b> </code> application/json
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code> <b>Accept-Encoding:</b> </code> gzip, deflate
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code> <b>Content-Type:</b> </code>application/json
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Resources</b> 
    /// </para>
    ///  
    /// <para>
    /// The following resources contain information about your IVS live stream (see <a href="https://docs.aws.amazon.com/ivs/latest/userguide/GSIVS.html">
    /// Getting Started with Amazon IVS</a>):
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Channel — Stores configuration data related to your live stream. You first create
    /// a channel and then use the channel’s stream key to start your live stream. See the
    /// <a>Channel</a> endpoints for more information. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Stream key — An identifier assigned by Amazon IVS when you create a channel, which
    /// is then used to authorize streaming. See the <a>StreamKey</a> endpoints for more information.
    /// <i> <b>Treat the stream key like a secret, since it allows anyone to stream to the
    /// channel.</b> </i> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Tagging</b> 
    /// </para>
    ///  
    /// <para>
    /// A <i>tag</i> is a metadata label that you assign to an AWS resource. A tag comprises
    /// a <i>key</i> and a <i>value</i>, both set by you. For example, you might set a tag
    /// as <code>topic:nature</code> to label a particular video category. See <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
    /// AWS Resources</a> for more information, including restrictions that apply to tags.
    /// </para>
    ///  
    /// <para>
    /// Tags can help you identify and organize your AWS resources. For example, you can use
    /// the same tag for different resources to indicate that they are related. You can also
    /// use tags to manage access (see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html">
    /// Access Tags</a>). 
    /// </para>
    ///  
    /// <para>
    /// The Amazon IVS API has these tag-related endpoints: <a>TagResource</a>, <a>UntagResource</a>,
    /// and <a>ListTagsForResource</a>. The following resources support tagging: Channels
    /// and Stream Keys.
    /// </para>
    ///  
    /// <para>
    ///  <b>API Endpoints</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a>Channel</a>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateChannel</a> — Creates a new channel and an associated stream key to start
    /// streaming.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetChannel</a> — Gets the channel configuration for a specified channel ARN (Amazon
    /// Resource Name).
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>BatchGetChannel</a> — Performs <a>GetChannel</a> on multiple ARNs simultaneously.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListChannels</a> — Gets summary information about channels. This list can be filtered
    /// to match a specified string.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateChannel</a> — Updates a channel's configuration. This does not affect an
    /// ongoing stream of this channel. You must stop and restart the stream for the changes
    /// to take effect.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteChannel</a> — Deletes a specified channel.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <a>StreamKey</a>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateStreamKey</a> — Creates a stream key, used to initiate a stream, for a specified
    /// channel ARN.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetStreamKey</a> — Gets stream key information for the specified ARN.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>BatchGetStreamKey</a> — Performs <a>GetStreamKey</a> on multiple ARNs simultaneously.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListStreamKeys</a> — Gets a list of stream keys. The list can be filtered to a
    /// particular channel.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteStreamKey</a> — Deletes the stream key for a specified ARN, so it can no
    /// longer be used to stream.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <a>Stream</a>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>GetStream</a> — Gets information about the active (live) stream on a specified
    /// channel.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListStreams</a> — Gets summary information about live streams.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StopStream</a> — Disconnects a streamer on a specified channel. This disconnects
    /// the incoming RTMP stream from the client. Can be used in conjunction with <a>DeleteStreamKey</a>
    /// to prevent further streaming to a channel.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>PutMetadata</a> Inserts metadata into an RTMP stream for a specified channel.
    /// A maximum of 5 requests per second per channel is allowed, each with a maximum 1KB
    /// payload.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html"> AWS Tags</a>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>TagResource</a> — Adds or updates tags for an AWS resource with a specified ARN.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UntagResource</a> — Removes tags from a resource with a specified ARN.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListTagsForResource</a> — Gets information about AWS tags for a specified ARN.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonIVS : IAmazonService, IDisposable
    {

        
        #region  BatchGetChannel


        /// <summary>
        /// Performs <a>GetChannel</a> on multiple ARNs simultaneously.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetChannel service method.</param>
        /// 
        /// <returns>The response from the BatchGetChannel service method, as returned by IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/BatchGetChannel">REST API Reference for BatchGetChannel Operation</seealso>
        BatchGetChannelResponse BatchGetChannel(BatchGetChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetChannel operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/BatchGetChannel">REST API Reference for BatchGetChannel Operation</seealso>
        IAsyncResult BeginBatchGetChannel(BatchGetChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetChannel.</param>
        /// 
        /// <returns>Returns a  BatchGetChannelResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/BatchGetChannel">REST API Reference for BatchGetChannel Operation</seealso>
        BatchGetChannelResponse EndBatchGetChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchGetStreamKey


        /// <summary>
        /// Performs <a>GetStreamKey</a> on multiple ARNs simultaneously.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetStreamKey service method.</param>
        /// 
        /// <returns>The response from the BatchGetStreamKey service method, as returned by IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/BatchGetStreamKey">REST API Reference for BatchGetStreamKey Operation</seealso>
        BatchGetStreamKeyResponse BatchGetStreamKey(BatchGetStreamKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetStreamKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetStreamKey operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetStreamKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/BatchGetStreamKey">REST API Reference for BatchGetStreamKey Operation</seealso>
        IAsyncResult BeginBatchGetStreamKey(BatchGetStreamKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetStreamKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetStreamKey.</param>
        /// 
        /// <returns>Returns a  BatchGetStreamKeyResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/BatchGetStreamKey">REST API Reference for BatchGetStreamKey Operation</seealso>
        BatchGetStreamKeyResponse EndBatchGetStreamKey(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateChannel


        /// <summary>
        /// Creates a new channel and an associated stream key to start streaming.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel service method.</param>
        /// 
        /// <returns>The response from the CreateChannel service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        CreateChannelResponse CreateChannel(CreateChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        IAsyncResult BeginCreateChannel(CreateChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChannel.</param>
        /// 
        /// <returns>Returns a  CreateChannelResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        CreateChannelResponse EndCreateChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateStreamKey


        /// <summary>
        /// Creates a stream key, used to initiate a stream, for a specified channel ARN.
        /// 
        ///  
        /// <para>
        /// Note that <a>CreateChannel</a> creates a stream key. If you subsequently use CreateStreamKey
        /// on the same channel, it will fail because a stream key already exists and there is
        /// a limit of 1 stream key per channel. To reset the stream key on a channel, use <a>DeleteStreamKey</a>
        /// and then CreateStreamKey.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamKey service method.</param>
        /// 
        /// <returns>The response from the CreateStreamKey service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/CreateStreamKey">REST API Reference for CreateStreamKey Operation</seealso>
        CreateStreamKeyResponse CreateStreamKey(CreateStreamKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStreamKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamKey operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStreamKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/CreateStreamKey">REST API Reference for CreateStreamKey Operation</seealso>
        IAsyncResult BeginCreateStreamKey(CreateStreamKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStreamKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStreamKey.</param>
        /// 
        /// <returns>Returns a  CreateStreamKeyResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/CreateStreamKey">REST API Reference for CreateStreamKey Operation</seealso>
        CreateStreamKeyResponse EndCreateStreamKey(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteChannel


        /// <summary>
        /// Deletes a specified channel and its associated stream keys.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteChannel service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        DeleteChannelResponse DeleteChannel(DeleteChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        IAsyncResult BeginDeleteChannel(DeleteChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChannel.</param>
        /// 
        /// <returns>Returns a  DeleteChannelResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        DeleteChannelResponse EndDeleteChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteStreamKey


        /// <summary>
        /// Deletes the stream key for a specified ARN, so it can no longer be used to stream.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStreamKey service method.</param>
        /// 
        /// <returns>The response from the DeleteStreamKey service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/DeleteStreamKey">REST API Reference for DeleteStreamKey Operation</seealso>
        DeleteStreamKeyResponse DeleteStreamKey(DeleteStreamKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStreamKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStreamKey operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStreamKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/DeleteStreamKey">REST API Reference for DeleteStreamKey Operation</seealso>
        IAsyncResult BeginDeleteStreamKey(DeleteStreamKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStreamKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStreamKey.</param>
        /// 
        /// <returns>Returns a  DeleteStreamKeyResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/DeleteStreamKey">REST API Reference for DeleteStreamKey Operation</seealso>
        DeleteStreamKeyResponse EndDeleteStreamKey(IAsyncResult asyncResult);

        #endregion
        
        #region  GetChannel


        /// <summary>
        /// Gets the channel configuration for a specified channel ARN. See also <a>BatchGetChannel</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannel service method.</param>
        /// 
        /// <returns>The response from the GetChannel service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/GetChannel">REST API Reference for GetChannel Operation</seealso>
        GetChannelResponse GetChannel(GetChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChannel operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/GetChannel">REST API Reference for GetChannel Operation</seealso>
        IAsyncResult BeginGetChannel(GetChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChannel.</param>
        /// 
        /// <returns>Returns a  GetChannelResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/GetChannel">REST API Reference for GetChannel Operation</seealso>
        GetChannelResponse EndGetChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  GetStream


        /// <summary>
        /// Gets information about the active (live) stream on a specified channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStream service method.</param>
        /// 
        /// <returns>The response from the GetStream service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ChannelNotBroadcastingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/GetStream">REST API Reference for GetStream Operation</seealso>
        GetStreamResponse GetStream(GetStreamRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStream operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/GetStream">REST API Reference for GetStream Operation</seealso>
        IAsyncResult BeginGetStream(GetStreamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStream.</param>
        /// 
        /// <returns>Returns a  GetStreamResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/GetStream">REST API Reference for GetStream Operation</seealso>
        GetStreamResponse EndGetStream(IAsyncResult asyncResult);

        #endregion
        
        #region  GetStreamKey


        /// <summary>
        /// Gets stream-key information for a specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStreamKey service method.</param>
        /// 
        /// <returns>The response from the GetStreamKey service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/GetStreamKey">REST API Reference for GetStreamKey Operation</seealso>
        GetStreamKeyResponse GetStreamKey(GetStreamKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetStreamKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStreamKey operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStreamKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/GetStreamKey">REST API Reference for GetStreamKey Operation</seealso>
        IAsyncResult BeginGetStreamKey(GetStreamKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStreamKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStreamKey.</param>
        /// 
        /// <returns>Returns a  GetStreamKeyResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/GetStreamKey">REST API Reference for GetStreamKey Operation</seealso>
        GetStreamKeyResponse EndGetStreamKey(IAsyncResult asyncResult);

        #endregion
        
        #region  ListChannels


        /// <summary>
        /// Gets summary information about channels. This list can be filtered to match a specified
        /// string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
        /// 
        /// <returns>The response from the ListChannels service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListChannels">REST API Reference for ListChannels Operation</seealso>
        ListChannelsResponse ListChannels(ListChannelsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannels operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListChannels">REST API Reference for ListChannels Operation</seealso>
        IAsyncResult BeginListChannels(ListChannelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannels.</param>
        /// 
        /// <returns>Returns a  ListChannelsResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListChannels">REST API Reference for ListChannels Operation</seealso>
        ListChannelsResponse EndListChannels(IAsyncResult asyncResult);

        #endregion
        
        #region  ListStreamKeys


        /// <summary>
        /// Gets summary information about stream keys. The list can be filtered to a particular
        /// channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreamKeys service method.</param>
        /// 
        /// <returns>The response from the ListStreamKeys service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListStreamKeys">REST API Reference for ListStreamKeys Operation</seealso>
        ListStreamKeysResponse ListStreamKeys(ListStreamKeysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListStreamKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStreamKeys operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStreamKeys
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListStreamKeys">REST API Reference for ListStreamKeys Operation</seealso>
        IAsyncResult BeginListStreamKeys(ListStreamKeysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStreamKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStreamKeys.</param>
        /// 
        /// <returns>Returns a  ListStreamKeysResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListStreamKeys">REST API Reference for ListStreamKeys Operation</seealso>
        ListStreamKeysResponse EndListStreamKeys(IAsyncResult asyncResult);

        #endregion
        
        #region  ListStreams


        /// <summary>
        /// Gets summary information about live streams.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreams service method.</param>
        /// 
        /// <returns>The response from the ListStreams service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListStreams">REST API Reference for ListStreams Operation</seealso>
        ListStreamsResponse ListStreams(ListStreamsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListStreams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStreams operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStreams
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListStreams">REST API Reference for ListStreams Operation</seealso>
        IAsyncResult BeginListStreams(ListStreamsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStreams operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStreams.</param>
        /// 
        /// <returns>Returns a  ListStreamsResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListStreams">REST API Reference for ListStreams Operation</seealso>
        ListStreamsResponse EndListStreams(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Gets information about the tags for a specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  PutMetadata


        /// <summary>
        /// Inserts metadata into an RTMP stream for a specified channel. A maximum of 5 requests
        /// per second per channel is allowed, each with a maximum 1KB payload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMetadata service method.</param>
        /// 
        /// <returns>The response from the PutMetadata service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ChannelNotBroadcastingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/PutMetadata">REST API Reference for PutMetadata Operation</seealso>
        PutMetadataResponse PutMetadata(PutMetadataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMetadata operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/PutMetadata">REST API Reference for PutMetadata Operation</seealso>
        IAsyncResult BeginPutMetadata(PutMetadataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutMetadata.</param>
        /// 
        /// <returns>Returns a  PutMetadataResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/PutMetadata">REST API Reference for PutMetadata Operation</seealso>
        PutMetadataResponse EndPutMetadata(IAsyncResult asyncResult);

        #endregion
        
        #region  StopStream


        /// <summary>
        /// Disconnects the stream for the specified channel. This disconnects the incoming RTMP
        /// stream from the client. Can be used in conjunction with <a>DeleteStreamKey</a> to
        /// prevent further streaming to a channel.
        /// 
        ///  <note> 
        /// <para>
        /// Many streaming client-software libraries automatically reconnect a dropped RTMP session,
        /// so to stop the stream permanently, you may want to first revoke the <code>streamKey</code>
        /// attached to the channel.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopStream service method.</param>
        /// 
        /// <returns>The response from the StopStream service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ChannelNotBroadcastingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.StreamUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/StopStream">REST API Reference for StopStream Operation</seealso>
        StopStreamResponse StopStream(StopStreamRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopStream operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/StopStream">REST API Reference for StopStream Operation</seealso>
        IAsyncResult BeginStopStream(StopStreamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopStream.</param>
        /// 
        /// <returns>Returns a  StopStreamResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/StopStream">REST API Reference for StopStream Operation</seealso>
        StopStreamResponse EndStopStream(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds or updates tags for a resource with a specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags for a resource with a specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateChannel


        /// <summary>
        /// Updates a channel's configuration. This does not affect an ongoing stream of this
        /// channel. You must stop and restart the stream for the changes to take effect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateChannel service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        UpdateChannelResponse UpdateChannel(UpdateChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        IAsyncResult BeginUpdateChannel(UpdateChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChannel.</param>
        /// 
        /// <returns>Returns a  UpdateChannelResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        UpdateChannelResponse EndUpdateChannel(IAsyncResult asyncResult);

        #endregion
        
    }
}