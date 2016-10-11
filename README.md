## Review of IPTV Interactive Services and Implementation of a Typical Service
An interactive service is one that enables user to receive a transmission of data specially created for the recipient, or upon request, whether or not as part of a program, which is selected by or on behalf of the recipient.
Interactive services present users with various capabilities. The service provider can combine these capabilities with other services to create two-way communications with the client. The application is implemented to be used on a platform, however it has the least confluence with the main processes of its platform and independently runs and interacts with the user.

### Commercial Innovation Strategies and Implementation Patterns in Interactive Services
 1. Adding supplemental features to existing services
 2. New interaction-based services
 3. Side-mode integration of existing services
 4. Personalization & thematic specialization of existing services
 5. Appending content-oriented interactions to existing services

![alt tag](https://raw.githubusercontent.com/minoobeyzavi/Review-of-IPTV-Interactive-Services-and-Implementation-of-a-Typical-Service/master/img.png)


### Interactive IPTV Applications

As the transition from all things analog to digital continues, iTV is becoming more and more prevalent. Thanks to increased bandwidth in new networking infrastructure and the great carrying capacity of the compressed digital signal, interactive content can be offered to more and more householders. iTV describes the phenomenon whereby users are enable to actively engage with content on their TV screens. iTV adds an extra layer of functionality to IPTV beyond on-demand and linear programming services.


It can provide viewers with access to further information, communication applications, and the facility to respond to interactive programming. Deployment of interactive applications involves the transition from one-way to two-way communications and passive to active viewing and viewer control. Applications and programming are transmitted to viewers’ set-top boxes and viewers can interact by using a navigational device such as a remote control or a wireless keyboard. Information sent by viewers is directed from the set-top box to a return path to the host’s network server. Deployment of interactive applications has occurred because a digital signal, which is compressed and transmitted at higher speeds in binary code, can carry more interactive content and numerous channels. iTV is distributed to people’s homes by terrestrial, cable, IPTV, and satellite television providers, each of these groups are consistently battling for a place in the viewers’ homes. All of these providers encourage viewers to subscribe to their pay TV, broadband, and telephone services and usually, they offer a variety of packages, which are designed for different audience types and the different budgets of their audiences.
In addition to allowing subscribers to watch linear video programming, IPTV brings Web-like interactivity to the traditional TV viewing experience. It allows service providers to differentiate their offerings from traditional television services. For consumers it allows them to view hundreds of channels, simultaneously record TV material, and access a range of interactive TV services including

### Types of Commercial Interactive Services
 1. Electronic Programming Guide
 2. VoD
 3. Browsing
 4. E-mail
 5. Caller ID
 6. Advertising
 7. GoD
 8. EAS
 9. DVR
 10. Walled Garden Portal
 11. Instant Messaging
 12. IPTV-Commerce
 13. Social Networking
 14. Localized Video Content
 15. Parental Control
 16. Personalized Channels
 17. Weather Forcast

Interactive television will provide genuinely useful applications that enhance the overall user experience of IPTV. Interactive services must be seen as part of the overall infrastructure of delivering television – not just a bolt on.
To get the right interactive services to meet consumer demands will require experimentation. Content providers, broadcasters and network owners need to develop, trial, refine and roll-out interactive services. A lot has been learnt over the past ten years about interactive TV. This knowledge can help inform the design of interactive services for IPTV.


 
#### Electronic Programming Guide

Since IPTV brings into the home many more channels and services, people need a way of navigating the myriad of choices. An application that does this is typically referred to as an electronic program guide. An EPG, also known as intelligent program guides (IPG), is an interface application that allows IPTV subscribers to preview, select, and connect to various types of IP and interactive TV services. The EPG application is generally a standard part of an IPTV service offering and is commonly used to navigate through a growing number of channels and sources of video content available to subscribers. An EPG presents IPTV subscribers with a menu of available IPTV channels in HTML format and a remote control is typically used to navigate this menu. Owing to the two-way nature of IPTV networks, it is possible to include several full days of programming information for every channel and detailed descriptions of every program within each channel. In addition, subscribers are able to search by genre, program title, channel, and even by time. Once a channel is selected, the video content is downloaded over the broadband network for immediate viewing. The EPG application is usually displayed on the TV screen in tabular or grid format. This type of design is generally easy to read and understand. It is however possible to change the look and feel of the EPG interface to meet the branding requirements of different IPTV service providers. The communication process between the client EPG application running on the IP set-top box and the server application uses standard Internet protocols. If the IPTV transmission network is using multicasting, then the program descriptions retrieved by the IP set-top box also contain port numbers and related multicast IP addresses.

##### Introduction to IPTV EPGs 

Also known as an event service guide, an IPTV EPG displays program lineup and episode information for current and future broadcast programming choices. It displays the current channel contents in a window, and allows IPTV subscribers to select a particular broadcast channel. Subscribers use the arrow keys on their remote controls to highlight and select various options. The functions of a standard IPTV EPG can include the following:
Displaying weekly schedules of IPTV multicast channels. Note that the channels accessible on the weekly channel are defined by the end-user access rights.
Automatic video recording.
Alerting subscribers about the arrival of new e-mail.
Reminding viewers when a selected program (or a program covering a selected topic) is about to be shown.
Restricting access to TV channels that are deemed inappropriate.
Allowing subscribers to find programs with a particular theme on a specified time or date.
Controlling disk storage devices in IP set-top boxes.
Previewing particular programs and personalizing TV viewing.
Some advanced IPTV systems even allow subscribers to program the EPG to make it look the way they want it.
A picture-in-guide is a variation of the standard IPTV EPG application that displays a selection of multicast channels within a small window (stamp like images) on the TV screen. The end user is able to use the arrows on their remote control to move from one window to the next. Each time a window is selected, the IPTVCD plays the sound associated with the particular channel. In addition to sound, the set-top will also display channel information including title, beginning, and ending times. By simply pressing the OK or Enter button on their remote control, the window extends to the full length and width of the television screen, the end user can sit back and watch the channel in comfort. From a network engineering perspective, multiple streams are required to support the provision of a picture-in-guide interactive TV application. This is problematic for service providers that operate networks with low bandwidth capacities. Note the delivery of this interactive IPTV application also requires picture-in-guide functionality to be built into the encoders at the IPTV data center.

##### IPTV EPG End-to-End

Network Architecture figure below describes the building blocks that comprise an end-to-end IPTV EPG solution:
The underlying technology platform has three major components, namely, a metadata generator, an EPG application server located at the IPTV data center, and a client EPG application resident on the IPTVCD. We explore these technical components in the following subsections.
Metadata Generator: The EPG needs schedule data to allow the viewer receive information about IPTV broadcast and on-demand services. The technical and industry term for this data is metadata. The metadata generator is at the heart of an end-to-end IPTV EPG system and allows IPTV service providers to acquire, edit, generate, and play out EPG schedule data over the network. IPTV metadata defines data about data and is typically formatted in XML. It combines video content information from both the content provider and network operator. The types of metadata provided by an IPTV system can include some of the following items:
List of channels available for the various tiered packages
IPTV channel name
IPTV channel description
IPTV channel logo
IPTV channel provider
IPTV channel provider’s Web site
Program title
Program start and finish times
Program language options
Detailed description of program contents
Parental control details and rating standards
Content aspect ratios
An indicator of whether captions are available or not
A description of any embedded advertisements
Compression techniques used on both audio and video content
Prices and access conditions for different items of IPTV content
Scheduled distribution time for delivery across the IP broadband network
Description of protocols and mechanism used to deliver the content
Caching details
Preview duration for IP-VoD assets
Recording rights
Applicability of content to particular types of IPTVCDs
Viewing profiles of IPTV end-users


##### End-to-end IPTV EPG system: Application Server 

The metadata generator interfaces with the EPG server to deliver program information to the EPG client application in a suitable format. The application server consists of software programs, a HTTP server, and a centralized database that contains the event data of all the broadcast programs on offer. It has four main functions:
(1) Formatting—The channel listing are generally formatted as Web pages.
(2) Authorization—The server in conjunction with the conditional access and digital rights management system authorizes access to particular channels.
(3) Provision of IP multicast addresses—The EPG server provides IP multicast addresses which are used by the router to stream the IP video channel across the core and access IP networks.
(4) Caching—The IPTV EPG server also provides caching functionality, which speeds up the EPG load time for end-users.
Client EPG Application The level of functionality provided by the EPG client
application can include some or all of the following features:
Allows end users to customize list of favorite multicast channels and on-demand titles.
Allows end users to change the look and feel of the screen layout.
Provides end users with an efficient mechanism of navigating through the various IPTV services and channels that are on offer from the network operator.


##### Launching an EPG via an IPTVCD connected to an IP

The steps involved in launching an EPG application are illustrated in the figure above and explained in following sections:
Step 1—The EPG key is pressed and the client application processes the
command.
Step 2—Launching of an EPG over an IPTV network utilizes a browser based client-server networking model. Thus, the next step in the process involves the establishment of a network connection between the EPG browser application and backend server.
Step 3—The command is received in the form of IP packets, authenticated, and a Web page is generated by the server. The Web page will contain channel information requested by the end user. This information will either be cached at the IPTV EPG server or requested from the metadata generator.
Step 4—The IPTV EPG server sends the results of the end-user request to the client EPG browser application.
Step 5—Results are received, rendered, and the EPG page is layed out on the TV display for use by the end user.


The EPG network architecture described above relies on the ability of the
network and backend servers to respond immediately to EPG instructions. On some occasions IPTV end users may experience delays due to congestion or other issues that slow down the processing of EPG requests. Where this occurs on a regular basis, service providers have an option of using an architecture that involves processing the EPG locally on the IPTVCD. Under this approach the basic EPG application normally resides in the IPTVCD’s storage system and accesses current meta-data from the IP network. Local storage of the EPG application speeds up broadband network response times for the end-user because it launches and operates immediately once the IPTVCD is powered on.


#### IP Based Video on Demand (VoD)

IPTV is often provided in conjunction with VoD. As the name implies VoD is a service that allows subscribers to select and download video content over an IP network. The content typically includes a library of films, music videos, and recorded television programs. The deployment of a VoD system falls into two broad categories:

Downloadable—the VoD content is delivered to the IP set-top box and the content is viewed once the downloading is finished.
Streaming—The IPTV set-top box receives the content via an IP stream.
A VoD system is the “holy grail” of viewing TV and enables an individual subscriber located in geographically dispersed locations to demand a program or movie when and where they want it.
The selection of a VoD title by an IPTV end user is relatively easy and typically comprises the following five steps:

The subscriber selects a VoD title from the interactive TV application.
The IPTVCD accepts the command and sends this instruction to the headend or data center.
The conditional access system is checked to verify that the subscriber is authorized to view the particular VoD title.
Once authorization is complete, a unicast video stream is forwarded to the regional office and onward to the IPTVCD.
The IP stream is controlled by the subscriber.

In addition to a high capacity two-way broadband network, the deployment of IP-VoD services also requires a number of other logical and physical technology blocks:

IP-VoD streaming server(s)
IP-VoD transport protocols
An Interactive IP-VoD client application

We explore these technology blocks in the following subsections.
IP-VoD Streaming Servers

In addition to the various processes that are executed in IPTV data centers, namely, encoding, multiplexing, and modulation, a number of high capacity computer servers are also installed to allow the delivery of IP-VoD services to various types of IPTVCDs. The main function of these VoD streaming servers is to retrieve and deliver on demand video content to a distribution network.
IP VoD servers are built using standard off-the-shelf computer and electronic components. Lots of processing power, fast input/output (I/O) systems, and large amounts of storage space are the main hardware characteristics of VoD streaming servers. Fortunately, for IPTV service providers the prices for these components continue to fall, while their capacities are continuing to rise. A video server typically includes redundant components such as power supplies, hot swappable hard drives and multiple CPUs. It acquires VoD assets from a number of content sources and is typically able to handle a range of different types of compression formats including MPEG-2, H.264/AVC, and VC-1. A Gigabit Ethernet output provides connectivity to the access network.
A large database of video movies and program assets resides on the server. The server receives requests for a particular content asset from VoD capable IPTVCDs, identifies the item, and streams the requested item to the IPTVCD.
The size and capabilities of the video server varies from supplier to supplier. A cluster of IP-VoD servers incorporate operating systems and application software that optimize the process of streaming video assets and simplify the day-to-day operations of the overall system. The operating systems used by VoD servers vary between vendors. The application software typically performs a number of critical functions.


##### Setting up a VoD stream

Management of Digital Streams: The setup, teardown, and control of VoD streaming sessions is a core function of the VoD server software.
A graphical illustration showing the steps associated with establishing an IP-VoD stream between a client IP set-top box and a backend VoD server is shown in the figure above and explained in the following sections.
Start communication with the CA System—On receipt of a request from the IP set-top box, the server software communicates with the CA system to determine if the IPTV subscriber has been authorized to view the requested IP VoD asset.
Identify appropriate IP-VoD Server—Once authorization has been verified, the software identifies a suitable VoD server cluster to fulfill the request. The location of this server or cluster of servers will depend on the IP subnet of the requesting set-top box.
Send encryption keys across network—Once the server cluster has been allocated, the backend software or the CA system sends a decryption key to the IP set-top box to facilitate decryption of the IP VoD content.
Send IP parameters—IP transport protocol parameters and the IP address of the VoD server is also sent to the IP set-top box.
IP VoD streaming commences—Bandwidth is allocated and streaming of the IP VoD asset commences. The IP set-top box uses a protocol called Real-Time Streaming Protocol (RTSP) to manage the flow of the stream.

While the stream is live on the network, it is the responsibility of the server software to ensure that if a fault occurs that the fail over system is activated and the stream continues without interruption.
Updating Digital Content: A VoD software infrastructure has to have the capability to automatically manage the updating of video content. Relying on a manual system to keep VoD content libraries up to date is problematic. 
The backoffice software ensures that all the digital assets included in the VoD library are current. This is achieved by automatically loading files from the content reception system into the VoD cluster of servers.
Replication Management: The backoffice software manages the replication of digital assets across a distributed networking infrastructure. In the event that new content is made available, it is the responsibility of this software to ensure that the asset is propagated to edge and cache servers around the network.
Management of Metadata: A centralized database is used to store the various attributes or metadata that are associated with each of the digital assets. Metadata is generally formatted as an XML file and provides descriptive data about each video asset. Metadata is typically used to search and browse VoD content. The types of metadata associated with a standard movie include
Movie producers name
Description
Date when the movie was created
Movie summary
Parental rating
Run time of the movie
Actor and director details
Genre
Licensing details
Royalty details
The backoffice software is responsible for ensuring the integrity of this metadata. Industry groups such as CableLabs have defined a standard for VoD metadata.
Search Capabilities: The indexing capabilities of video server software allow IPTV end users to carry out searches for digital assets on the backend IP-VoD servers.
Managing Access of IP-VoD Digital Assets: The server software provides an external interface to the service provider’s back office components — the conditional access, digital rights management, and billing systems. Inputs from this interface are used to control and manage access to the digital VoD assets.
Interfacing with IPTVCDs: The back-office software is also responsible for interfacing and communicating information about VoD assets that are available for purchase to the VoD client software application installed on various types of IPTVCDs.

##### IP VoD Transport Protocols

IP VoD servers typically use the Real-time Transport Protocol (RTP) and Real-time Control Protocol (RTCP) to stream video data to an IPTVCD. The Real-Time Streaming Protocol is subsequently used to control these streams. The following sections give a brief overview of these three protocols when used in an IPTV infrastructure.

Overview of RTP and RTCP
As the name suggests RTP is a native part of the IP suite of communication protocols. It was published as a standard by the ITU-T and has been specifically designed to carry signals for a wide range of realtime applications.
In addition to IPTV there are several other applications that use the RTP protocol ranging from video conferencing to VoIP. Applications that run RTP usually do so on top of the UDP and IP protocol layers. This is because RTP provides appropriate QoS mechanisms and is able to recover from problems that go undetected by UDP.
RTCP or the control part of RTP monitors the quality of real-time IPTV services. Its main function is to work with protocols such as UDP to provide feedback information to the IPTV data center systems about the quality of data delivery and reception. The types of feedback information ranges from how many IPTV packets were lost while traversing the network to delays in the delivery of IPTV packets.

RTSP Overview 
Real-Time Streaming Protocol is an application level protocol belonging to the IP communication model that enables IPTVCDs to establish and control the flow of IPTV streams. The specification for RTSP was published in 1998 and can be found in RFC 2326. It allows IPTVCDs to issue VCR style commands to an IPTV streaming server. The figure below shows how these protocols interact with each other.


##### RTP protocol stack

In addition to VCR type functionality, RTSP also allows an IPTVCD to request and retrieve a particular item of IPTV content. The fulfillment of this request involves the inclusion of the appropriate VoD servers IP address inside the request command issued by the IPTVCD.

Interactive IP-VoD Client Application

A deployment of a generic IP-VoD system architecture is based on a client/server computing model. This means that a dedicated point-to-point connection is setup between the IPTVCD and the server at the data center. To interoperate with the data center server over this connection the IPTVCD requires a VoD client software application that is capable of receiving IP based VoD streams. The client application presents the IPTV end user with a menu of video assets and associated descriptions on their television screen. The contents of the menu are based on the programming package that the consumer has subscribed to. The technical gathering of this information is called service discovery and varies between networks. For instance, on a DVB network the system used to discover information about available on-demand services is a standard XML record, which is predefined.

In addition to allowing subscribers to select and download specific movies a typical IP-VoD client application also supports content searching and stream control functionality. An implementation of the client IP-VoD application is typically implemented through an embedded HTML browser.


#### IPTV Browsing

Many IPTV network operators provide viewers with access to the Web. This can be in the form of either TV-based Web browsing (WebTV) or Walled gardens. TV based Web browsing is similar to browsing on a PC but it is TV based. Since many Web pages are not tailored for viewing on TV, some network operators provide an embedded browser on their IP set-top boxes that change a Web page automatically. Such software can be provided as part of a middleware platform. 

The concept of using a television set to bring Web connectivity has been commercially available for over a decade but due to a whole raft of reasons consumers have continued to reject the use of this interactive TV application. With advancements in IPTV and Web technologies the popularity of accessing Web content via TV applications is expected to grow in the coming years.
Web browsing is a key component of an IPTV system. In the figure below, the structure of a generic infrastructure used by IPTV operators to deliver high speed Web access to their subscribers is illustrated.
As shown, an end-to-end system includes: the IPTVCD Web browser, a HTTP Web server, caching servers, and a high-speed backhaul connection to the Internet.

##### IPTVCD Browsers

Browsers built for IPTVCDs need the same robust functionality found in desktops, but with access to a fraction of the hardware resources. Therefore, they are optimized to run within resource constrained platforms such as set-top boxes, mobile phones, and Internet-enabled appliances. The browser software runs on top of the underlying real-time OS and middleware platforms and typically provides the following functionality:
Displaying Web pages—Putting a Web page on a television screen is very different to displaying the same page on a computer monitor. It must be remembered that the television has been in existence for over a hundred years. Therefore, IPTVCDs employ sophisticated software browsers to ensure that Web pages are easily viewed on a TV screen.
 
##### Technical building blocks of an IPTV browsing system

IPTVCD browsers are able to squeeze the content of a Web page on to a television screen, while limiting the affects of viewing content on a low resolution device. This process is called transcoding and involves repurposing Web content into a simpler format that is suitable for display on a standard television. 
Transcoding can be divided into two broad categories: HTML and Image Transcoding. The transcoding of HTML content includes checking the code for any errors. An example of an HTML error would be the absence of a </html> tag on a standard Web page. Transcoding filters these errors and produces a version of HTML that can be easily rendered by the IPTVCD browser. In addition to checking for errors, the HTML transcoding element is also capable of changing the layout to a TV centric format. For example, the default font size for a Web browser is normally 10 points. If this font size were to be displayed on a television screen, then it would be very difficult to read. Consequently, the transcoding engine will automatically increase the size of the font to 20 or 22 points. This approach means that less text can be displayed on a TV screen than in a comparable area of a computer monitor. However, the text is legible for subscribers that are viewing the page from a distance of 4--5 ft away from the television display. In addition to automatically adjusting font sizes, transcoding takes care of adjusting the size of a page to fit within the width and height of a TV screen. 

Image transcoding is responsible for converting the many image formats used on the Internet to a format that is suitable for an IPTV environment. Flat-color GIFs are processed more readily by IPTVCDs than JPEGs or PNGs. So, for instance, when an IPTV subscriber makes a request for a document on the public Internet, which contains JPEG images, the image transcoder is able to convert the images into a GIF format. In addition to translating the file format, some advanced browsers are also capable of formatting and scaling graphics for a television screen.
As shown in the figure below, an IPTVCD browser consists of a presentation engine that processes and renders a number of different types of open Internet and TV content formats.


###### IPTVCDs supported browser formats

###### A Web Server 

A Web server, also known as an HTTP server, is basically a file server. A Web server’s main function within an IPTV network is to listen for and respond to HTTP requests from IPTVCD browser clients. When a request is received, the server opens a connection to the browser and sends the requested file or Web page. After servicing the request, the server returns to its listening state, waiting for the next HTTP request. HTTP is extremely rapid. According to Tim Berners-Lee, the developer of HTTP, the request is made and the response is given in a cycle of 100 ms. The delays experienced are usually the result of congestion on the IP based network. In addition to responding to requests from browsers, Web servers are also responsible for completing other tasks including
Logging activity on the IPTV network
Protecting Web pages from unauthorized users
Sending requests to peer Web servers on the public Internet
The hardware requirements for a Web server will vary according to the level of interaction between the IP set-top box and the Web server.

##### Caching Servers 

When using a resource constrained device such as a set-top box to browse the Web, it makes sense to incorporate optimized caching within the overall system architecture. The caching servers are normally located at the IPTV service provider’s regional office at the edge of the core IP backbone network. The caching technique employed by IPTV systems involves the storage of popular Web pages on the server. The various caching servers used by an IPTV browsing application use standardized communication protocols to “talk to each other,” thus ensuring that local Web pages are kept current. Caching servers fall into two broad categories: software that runs on a standard server or a dedicated hardware platform.
Note that in addition to the above technologies, a high speed and resilient connection to the public Internet is also required for IPTV browsing services.


#### IPTV E-Mail

From the earliest days of society people have used various systems and technologies to communicate with each other. With the recent explosion of the Internet, the most popular means of communicating between computers is electronic mail (e-mail). With the advent of IPTV, e-mail is now poised to enter the living room.



The figure below shows how an end to end IPTV e-mail solution might look like. As illustrated the major components of a fully built end-to-end IPTV e-mail system include the client software resident in the IPTVCD, a suite of communication protocols, servers, and a firewall located at the IPTV data center.


##### End-to-end IPTV e-mail solution

##### IPTVCD E-Mail Clients 

The IPTVCD with its interactive capability is seen by many as a natural environment for e-mail in the home. The client e-mail application is normally integrated with the IPTVCD middleware and uses the TCP/IP protocol to communicate with the IPTV data center. Modern IPTV e-mail applications fulfill a wide range of functions and let subscribers do more than just send or receive mails. For instance, the attachment of files to e-mails is supported. This might sound like a trivial feature but in the world of IPTV and thin IPTVCD clients the implementation of attaching files poses some technical challenges. For instance, IP set-top boxes do not have the processing power or storage capacity necessary to run popular programs that are needed to open file attachments. Therefore, the IPTV e-mail client needs to convert the attachment into HTML format and then use the browser to display the file. Other features supported by IPTV e-mail clients include personal address books and support for encryption.

##### Networking and Communication Protocols 

E-mail messages are always transmitted in American Standard Code for Information Interchange (ASCII) format. ASCII files are text-only files. The transfer of e-mail messages in an IPTV environment are normally based on Internet mail standards such as SMTP, MIME, IMAP4, and POP3.
SMTP—stands for Simple Message Transfer Protocol. It is used to transfer IPTV mails from the mail server located at the data center to another e-mail server on the Internet, and is designed for reliable and efficient mail transfer. SMTP forms part of the TCP/IP protocol stack, and is used to specify how e-mails should be passed from transmitting to receiving hosts.
MIME—stands for Multipurpose Internet Mail Extensions. MIME is an Internet standard that lets IPTV e-mail clients automatically encode and decode binary files from their original format into a format that is viewable on a television screen. It specifies how non-ASCII messages should be formatted so that they can be sent over the public Internet. Examples of non-ASCII messages include graphic, audio, and video files. This protocol allows IPTV e-mail systems to support much more than just text messages. There are many predefined MIME formats, including JPEG file graphics, and PostScript files.
POP3—stands for Post Office Protocol version 3. It is used by IPTVCD e-mail clients to access messages stored on the mail server.
IMAP—stands for Internet Message Access Protocol, the latest version of this protocol, IMAP4, has similar functionality to POP3 but does support additional features, which are useful for IPTV end users. E-mail searching using keywords while the e-mails remain on the server is one example of an IMAP feature that is not supported by POP3.

##### E-Mail Servers 

Every IPTV subscriber that avails of the e-mail service receives a unique e-mail address and a mailbox. The mailboxes are stored and managed on mail server gateways at the IPTV data center. These servers are connected to the Internet and also interface with the OBSS for billing purposes. The mail server gateway is a software program that runs on a mail server and links the IPTV network through a firewall to the public Internet.


#### IPTV E-Mail

From the earliest days of society people have used various systems and technologies to communicate with each other. With the recent explosion of the Internet, the most popular means of communicating between computers is electronic mail (e-mail). With the advent of IPTV, e-mail is now poised to enter the living room.


The figure below shows how an end to end IPTV e-mail solution might look like. As illustrated the major components of a fully built end-to-end IPTV e-mail system include the client software resident in the IPTVCD, a suite of communication protocols, servers, and a firewall located at the IPTV data center.


##### End-to-end IPTV e-mail solution

##### IPTVCD E-Mail Clients 

The IPTVCD with its interactive capability is seen by many as a natural environment for e-mail in the home. The client e-mail application is normally integrated with the IPTVCD middleware and uses the TCP/IP protocol to communicate with the IPTV data center. Modern IPTV e-mail applications fulfill a wide range of functions and let subscribers do more than just send or receive mails. For instance, the attachment of files to e-mails is supported. This might sound like a trivial feature but in the world of IPTV and thin IPTVCD clients the implementation of attaching files poses some technical challenges. For instance, IP set-top boxes do not have the processing power or storage capacity necessary to run popular programs that are needed to open file attachments. Therefore, the IPTV e-mail client needs to convert the attachment into HTML format and then use the browser to display the file. Other features supported by IPTV e-mail clients include personal address books and support for encryption.

##### Networking and Communication Protocols 

E-mail messages are always transmitted in American Standard Code for Information Interchange (ASCII) format. ASCII files are text-only files. The transfer of e-mail messages in an IPTV environment are normally based on Internet mail standards such as SMTP, MIME, IMAP4, and POP3.
SMTP—stands for Simple Message Transfer Protocol. It is used to transfer IPTV mails from the mail server located at the data center to another e-mail server on the Internet, and is designed for reliable and efficient mail transfer. SMTP forms part of the TCP/IP protocol stack, and is used to specify how e-mails should be passed from transmitting to receiving hosts.
MIME—stands for Multipurpose Internet Mail Extensions. MIME is an Internet standard that lets IPTV e-mail clients automatically encode and decode binary files from their original format into a format that is viewable on a television screen. It specifies how non-ASCII messages should be formatted so that they can be sent over the public Internet. Examples of non-ASCII messages include graphic, audio, and video files. This protocol allows IPTV e-mail systems to support much more than just text messages. There are many predefined MIME formats, including JPEG file graphics, and PostScript files.
POP3—stands for Post Office Protocol version 3. It is used by IPTVCD e-mail clients to access messages stored on the mail server.
IMAP—stands for Internet Message Access Protocol, the latest version of this protocol, IMAP4, has similar functionality to POP3 but does support additional features, which are useful for IPTV end users. E-mail searching using keywords while the e-mails remain on the server is one example of an IMAP feature that is not supported by POP3.

##### E-Mail Servers 

Every IPTV subscriber that avails of the e-mail service receives a unique e-mail address and a mailbox. The mailboxes are stored and managed on mail server gateways at the IPTV data center. These servers are connected to the Internet and also interface with the OBSS for billing purposes. The mail server gateway is a software program that runs on a mail server and links the IPTV network through a firewall to the public Internet.


#### Caller ID for TVs

This IPTV application allows consumers who have subscribed to a caller ID service through their telephone company to view caller information on the TV screen. In other words, when the phone rings a pop-up window appears on the television to notify the end user of the name and phone number of the incoming caller. 

Advanced versions of this IP application allow the simultaneous pop-up of caller ID windows on multiple PC’s and TV screens around the house. A high level overview of the two main components required to deploy a caller ID service on an IPTV network are shown in the figure below and explained in the following sections.
An application server—This server is normally located in the IPTV data center and supports a wide range of telecommunication protocols. When a call arrives, the signal is routed to this server and a communication session is established with the IP set-top box. Additional functions of this application server range, from communicating with the back office provisioning and management systems to managing data transfer across the network.

##### Components of an end-to-end caller ID IPTV application

A client IPTVCD software application—the display of caller ID details on a TV requires the installation or activation of a specialized piece of software on the IPTVCD. This software module integrates with the IPTVCD operating system and is typically branded by the IPTV service provider. This application is responsible for ensuring that the name and number of the incoming caller appears on the subscriber’s TV screen.
The caller ID application can also be used to display notifications of other types of incoming messaging services including voicemails, and text messages. The caller ID for TVs is an extremely popular application amongst IPTV subscribers and is one practical example of how converged services will have an impact on people’s lives in the years ahead.


#### IPTV Advertising

The use of interactive TV as a medium to deliver advertising is rapidly emerging into a mainstream application. The fact that it allows advertisers and service providers to engage consumers with a compelling suite of advertisements is considered to be one of the main drivers of this type of IPTV application. IPTV is capable of supporting a range of different IPTV ad formats, including telescoped long form adverts and integrated links that are embedded directly into the content. 

In addition to the various ad formats, IPTV allows operators to place adverts into both the standard broadcast programming streams and the increasingly popular method of delivering content on-demand. Not only does IPTV advertising provide advertisers with a one-to-one connection with consumers but it also represents a significant revenue opportunity for telecommunication operators deploying IPTV services. The advent of new targeted advertising technologies that run across IP networks are now starting to appear in different IPTV deployments across the world. The two key benefits of these new IP based systems compared to traditional advertising systems that operate over RF based networks are
Two-way capabilities—Owing to the fact that all of the IPTV deployments are operating over bidirectional broadband networks means that these new advertising systems are able to collect and monitor in real-time viewer reactions to advertisements. This feature allows advertisers to immediately gauge the effectiveness of a particular marketing campaign.
Individual IPTVCDs can be addressed directly—The deployment of targeted ad insertion techniques on an IPTV system enables service providers, content programmers, and advertisers to target their advertising messages to individual IPTV viewers. This is a major benefit over current advertising systems, which are limited to targeting commercial advertisements to specific geographical areas.


The functionality provided by this application allows subscribers to retain control of their video content viewing experience while ensuring that they only receive adverts on products and services that align with their interests in an opt-in basis. From an advertiser’s perspective, the availability of accurate user data helps to increase the success of their advertising campaigns by allowing them to focus on viewer’s interests. Service providers also benefit from this level of functionality because it helps to create a new television advertising revenue stream. The six major hardware and software components of a fully built end-to-end addressable advertising system are depicted in the figure below and described in the following sections.

##### IPTV targeted advertising system

Content reception—In an IPTV advertising system, the television channel is typically received from off-air or from a satellite feed and forwarded to the splicer. Special advert markers are sometimes included in this stream, which pinpoint the sections of the video stream that are allocated for ad inserts.
Advert server—Advertisements are typically pre-recorded and stored digitally on this special purpose video server located at the IPTV provider’s data center. The server streams these advertisements to the splicer.
Advert splicer—The purpose of this piece of hardware is to insert adverts retrieved from the advert server into the IPTV streams.
Advertisement management system—This is a piece of software that runs on a PC or server. It ensures that the correct adverts are inserted into the correct IPTV streams at the specified time slots. Some of the more advanced systems support the creation of specific marketing campaigns based parameters such as programming type, geography, and demographic data.
Broadband access router—This router streams the IP video streams with the embedded digital adverts on to the core and access IP networks.
IP set-top box—The targeting of adverts over an IPTV network generally starts with the subscriber who uses their IPTV interface to create a personal profile that outlines the types of adverts they would like to view. This profile information and related viewing statistics is then used by advertising companies to reach IPTV subscribers who have an interest in a specific category of products or services.
The deployment of an IPTV targeted advertising system is rarely implemented in isolation and is usually integrated into an IPTV data center in conjunction with a number of other third-party systems.


#### Gaming on Demand (GoD)

IPTV technologies also allow telecom operators to deliver interactive TV gaming applications to their customers. The addition of online gaming applications to a portfolio of IPTV services can not only help to generate additional revenue streams for telecom operators but also reduce customer churn. In addition to subscriptions, IPTV providers can also place adverts in IP based games that connect advertisers with end users. The GoD application allows IPTV subscribers to

play high quality premium games from the comfort of their homes;
play with other gamers connected to the Internet;
participate in text, phone, or emoticon messaging during game play.

The two major components of an IP based on-demand gaming system are depicted in the figure below.
Gaming servers—A client-server computing architecture is generally used to deploy this type of IPTV application. The servers are located at the IPTV data center and typically integrate seamlessly into existing VoD infrastructures. A server may be involved in two types of tasks with the deployment of online games: store the various game titles and interpreting instructions from the IP set-top box.
Online gaming client applications—IPTV gaming applications run locally or remotely, dependent on the hardware capabilities of the IPTVCD. A remote control or specialized joystick is typically used to play the games. The UDP/IP protocol layers of the IPTVCM are used to carry the gaming content both upstream and downstream to the client IPTVCD.
Although games deployed by IPTV systems are a far cry from the advanced games that are played on dedicated game consoles, the level of sophistication used by IPTV games has improved dramatically in recent times and this trend is expected to continue into the future.


#### Weather Forecast

Many IPTV network operators provide viewers with access to the weather forecasts information. IPTV based weather application is similar to weather applications that are designed to work on a PC but it is TV based. With this service you can have dynamic weather information right on your TV screen. This fun-to-use application provides current conditions and forecasts, as well as localized and accurate weather information for wherever in the world. More advanced versions might also provide the subscriber with, severe weather alerts for upcoming extreme weather conditions, updated each hour, including hourly forecasts and information for the next hours and days, animated radar and satellite images, videos, and even interactive weather maps.
IPTV network operators provide an embedded software application on their IP set-top boxes that receives data about current weather conditions and displays this information on the TV screen. Such software can be provided as part of a middleware platform.
Weather application is the most popular interactive service of an IPTV system. In the figure below, the structure of a generic infrastructure used by IPTV operators to deliver high speed access to weather information to their subscribers is illustrated. 
As shown, an end-to-end system includes: the IPTVCD weather application, a HTTP Web server, and a high-speed backhaul connection to the Internet.


##### Technical building blocks of an IPTV weather forecast service.

##### IPTVCD Weather Application

The weather application written for IPTVCDs need the same robust functionality found in desktops, but with access to a fraction of the hardware resources. Therefore, they are optimized to run within resource constrained platforms such as set-top boxes, mobile phones, and Internet-enabled appliances.
The weather forecast software runs on top of the underlying real-time OS and middleware platforms and typically provides the following functionality:
It gives you instant access to real-time local weather and alerts you whenever severe storms threaten. You're just one step away from detailed information on your local weather conditions as well as your favorite cities worldwide. More advanced versions can also provide:


weather maps
animated radar
hourly and daily forecasts
local/national maps
satellite images
weather alarms
hurricane central
weather videos
severe weather alert
weather trivia, photos and cartoons
weather news
customizable look & feel

It might even present the subscribers with weather and health information for the exercise enthusiast or doctors and those with health concerns - arthritis, asthma, flu, migraine allergies and more.
The weather application is pre-embedded in the client’s IPTVCD and works on top of the IPTV middleware.

##### A Web Server
 
A Web server, also known as an HTTP server, is basically a file server. A Web server’s main function within an IPTV network is to listen for and respond to HTTP requests from IPTVCD weather application clients. When a request is received, the server opens a connection to the application and sends the requested weather forecast information. After servicing the request, the server returns to its listening state, waiting for the next HTTP request. HTTP is extremely rapid. According to Tim Berners-Lee, the developer of HTTP, the request is made and the response is given in a cycle of 100 ms. Therefore the viewer will always have access to weather information that is current and up to date. In addition to responding to requests from applications, Web servers are also responsible for completing other tasks including:
Connecting to various weather servers through the Internet;
Checking for new information periodically and keeping the data up to date.


The hardware requirements for a Web server will vary according to the level of interaction between the IP set-top box and the Web server.
We should note that in addition to the web server and the weather application, we also need a broadband connection to the Internet to deploy this service on an IPTV platform.
