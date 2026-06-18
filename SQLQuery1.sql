
ALTER TABLE dbo.IssueReturn 
DROP CONSTRAINT FK_IssueReturn_Members;
GO


ALTER TABLE dbo.IssueReturn 
ADD CONSTRAINT FK_IssueReturn_Members 
FOREIGN KEY (MemberID) REFERENCES dbo.Members(MemberID) 
ON DELETE CASCADE;
GO