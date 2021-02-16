# SmokeBall

As being asked to over engineer the code here is my solution:
This project is a WPF project to implement Google search assignment.
I’ve decided to go with abstract factory design pattern to make it possible to extend the application later with different types of search with different search engines.
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

The search engine we are providing at this stage is google, so GoogleFactory is the class implements ISearchAbstractFactory interface.
At the moment this class just implements the ITextSearchAbstract and returns an exception for the rest.
to implement methods of ITextSearchFactory I had to use the async method (webClient.DownloadStringTaskAsync) as the sync one blocks the UI.
 We also have SearchClient class which has the benefit of dependency inject passed to the constructor. the class gets the ISearchAbstractFactory in the constructor and is in charge to call the needed method of each for it’s own methods that at the moment is just 
-	SearchKeyword(string keyword)   search for a keyword and return the whole result
-	SearchKeyword(string keyword,int resultCount) search for a keyword and return the first resultcount rows(at the moment 100)


There is also a custom exception (SearchEngineNotFoundException) to be thrown whenever the functionality of a search engine is not implemented.

When the app comes up an instance of GoogleFactory will be created (as it’s the only one we work with at the moment) and being used whenever is needed.


On the UI, I‘m using a grid to be able to get the control in rows and columns.
there is a textbox for user to type the search phrase (keywords separated by comma).
the default value is Conveyancing software as requested.

The result will be shown in another textbox which is read-only and bind-ed to a property to be able to get updated when the result is ready.

When user clicks on search button the input text box and the button will be disabled, and after the result is ready it’s going to be enabled again.


I’ve also provided a unit test project to be able to test the functionalities as much as possible.
In my unit tests, I’m using Moq package to be able to mock the interfaces and their behaviors to check the result.

