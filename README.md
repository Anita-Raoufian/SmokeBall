# SmokeBall

This is an assignment for Smokeball company.
A WPF project to implement Google search for provided keywords and the result would be the ranking of the www.smokeball.com.au on the list.

It's been asked to over engineer the code that's why I've decided to think of it as a bigger project working with different seach engines in the future:

Usiing Abstract factory design pattern makes it possible to extend the application later with different types of search with different search engines.

ISearchAbstractFactory
Is the abstract factory which has 3 methods as below:

	IImageSearchAbstract GetImageSearch();
	IVideoSearchAbstract GetVideoSearch();
	ITextSearchAbstract GetTextSearch();

Each implement an interface related to a specific search type.

Interface: IImageSearchAbstract	
	Method to be implemented: FindByImageName(string imageName)	
	Returns: List<Image>
	
Interface: IVideoSearchAbstract	
	Method to be implemented: FindByVideoName(string videoName)	
	Returns: List<VideoDrawing>

Interface: ITextSearchAbstract 
	Methods to be implemented: FindByKeyword(string keyword) , FindByKeyword(string keyword,int num)	
	Return: List<string>

The search engine provided at this stage is google, so GoogleFactory is the class implements ISearchAbstractFactory interface.
At the moment this class just implements the ITextSearchAbstract and throws an exception for the rest.
to implement methods of ITextSearchFactory I had to use the async method (webClient.DownloadStringTaskAsync) as the sync one blocks the UI.
 
In the code SearchClient class has the benefit of dependency injection through it's constructor. 
the class gets the ISearchAbstractFactory in the constructor and is in charge to call the needed methods that for now is just 
-	SearchKeyword(string keyword)   search for a keyword and return the whole result
-	SearchKeyword(string keyword,int resultCount) search for a keyword and return the first resultcount rows(at the moment 100)


There is also a custom exception (SearchEngineNotFoundException) to be thrown whenever the functionality of a search engine is not implemented.

When the app comes up an instance of GoogleFactory will be created (as it’s the only one we work with at the moment) and being used whenever is needed.


On the UI, a grid makes it possible to control the components positions in rows and columns.
there is a textbox for user to type the search phrase (keywords separated by comma).
the default value is Conveyancing software as requested.

The result will be shown in another textbox which is read-only and bind-ed to a property to be able to get updated when the result is ready.

When user clicks on search button the input text box and the button will be disabled, and after the result is ready it’s going to be enabled again.


Unit test project is also provided to be able to test the functionalities as much as possible.
Moq package is installed to be able to mock the interfaces and their behaviors to check the result.

