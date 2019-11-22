Feature: toastJs

@mytag
Scenario: Show Toast Title and Message
	Given Im on the ToastJs
	And I write "title" as title
	And I write "message" as message
	When I press the show toast
	Then the show toast title and message
