# Testing Documentation for PBL (NFT Markeplace)
### Introduction
Purpose of the document:
	This Document will provide a better understanding of the future tests. 
Scope of the tests
	This tests are very important for understanding and observing the weakest parts of our applications, to find the potential bugs and understanding what do we have to change before this problems will become a big stopholders for the project.
### Test Environment Setup
 Required software and tools:
1. Trello - in our project is used to manage all types of testing and other activities. For tests are used next cards from the list bar: 
- **Testing** (for those tasks that are in Testing phase right now);
- **On Hold** (if a specific Test will be provided later)
- **Done** (if a piece of project was developed and tested it comes here)

| To Do | Pivotal | In Progress | Testing | On Hold | Done | Presented | To Read |
| ----- | ------- | ----------- | ------- | ------- | ---- | --------- | ------- |

2. Obsidian - in our project I use this tool, to manage all personal work and progression, especially when we talk about Raport and Testing Documentation 
3. Metamask Wallet - for all money interactions, purshasing and selling our system uses only Metamask Wallet
4. Specific Test Tool - for different types of testing will be 
### Functional Tests
1. **User Registration and Login**
- Verify user can register using Metamask
- Ensure wallet connection prompts as expected.
- Verify the reasons for invalid results
2. **NFT Creation and Minting**
- Check minting with various formats (image, video, audio)
- Validate smart contract interaction
- Tests the requirements for Minting
3. **Listing NFTs**
- Verify listing of NFTs for fixed price 
4. **Payment Integration**
- Test Metamask payment integration
- Should be Done before Buying and Selling
5. **Buying and Selling**
- Ensure user can buy an NFT 
- Verify Payment was succed
### Boundary Tests
-
### Security Tests
1. **Smart Contract Security**
- Verifying the proper work of the Smart Contract
- Check if there are possibilities to outcome the smart contract in your favor
2. **Data Protection**
- Check if the Data is secured from possible hacking 
### Performance Tests
1. **Load Testing**
- Simulate high traffic to test the system’s response.
2. **Response Time**
- Record average transaction processing time.
3. **Scalability Testing**
- Assess performance under different load sizes.
### User Interface (UI/UX) Tests
1. **Homepage and Navigation**
- Test if the homepage layout is responsive across different devices and browsers.
- Verify that the navigation menu and search bar work correctly.
- Ensure the marketplace categories, filters, and sorting options are accessible and functional.
2. **NFT Details Page**
- Validate that clicking on an NFT opens a detailed view with the correct information.
- Check the display of NFT metadata (e.g., ownership history, description, and royalties).
- Ensure the "Buy Now" button is visually prominent and functional.
3. **Dark Mode and Themes** (optional)
- Check if dark/light mode toggles properly.
- Ensure text and elements remain readable in all themes.
4. **Messages**
- Verify the usability and design of the messaging feature (if applicable).
### Integration Tests
1. **Smart Contract Interaction**
- Verify the deployment and execution of smart contracts for NFT minting, buying, and selling.
- Test royalty payments to the creator after resale.
2. **Marketplace Transactions**
- Validate end-to-end purchase flow: Buyer selects an NFT -> wallet interaction -> transaction confirmation.
- Ensure ownership transfer is reflected both in the marketplace and blockchain. 
3. **Notifications System**
- Test if notifications (e.g., transaction success, bids, offers) trigger appropriately.
- Ensure integration with email or in-app notification services.
4. **Admin Features**
- Verify admin privileges for moderating listings, blocking accounts, or resolving disputes.
### Regression Tests
- Re-run critical tests after updates to the platform or contracts.
### Best Practices and Recommendations
Verify if the Best Practices were provided for the project (expecially Front-End)
