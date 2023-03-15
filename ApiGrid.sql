ALTER PROCEDURE Subscription4Show
@RowsOfPage int,
@PageNumber int,
@Column VARCHAR(MAX) = NULL,
@pagematch nvarchar(max) = NULL
AS
BEGIN
SELECT * FROM Subscription4
where Subscriptionprice LIKE '%' + ISNULL(@pagematch ,Subscriptionprice) + '%'
ORDER BY CASE
WHEN @Column = 'SubscriptionId' THEN CAST(SubscriptionId AS SQL_VARIANT)
WHEN @Column = 'Subscriptionprice' THEN CAST(Subscriptionprice AS SQL_VARIANT)
WHEN @Column = 'NoOfdays' THEN CAST(NoOfdays AS SQL_VARIANT)
WHEN @Column = 'CreatedBy' THEN CAST(CreatedBy AS SQL_VARIANT)
WHEN @Column = 'CreatedOn' THEN CAST(CreatedOn AS SQL_VARIANT)
WHEN @Column = 'UpdatedBy' THEN CAST(UpdatedBy AS SQL_VARIANT)
WHEN @Column = 'UpdatedOn' THEN CAST(UpdatedOn AS SQL_VARIANT)
WHEN @Column = 'CreatedIp' THEN CAST(CreatedIp AS SQL_VARIANT)
WHEN @Column = 'UpdatedIP' THEN CAST(UpdatedIP AS SQL_VARIANT)
WHEN @Column = 'Active' THEN CAST(Active AS SQL_VARIANT)
END
OFFSET ( @PageNumber -1 ) * @RowsOfPage ROWS
FETCH NEXT @RowsOfPage ROWS ONLY
END

