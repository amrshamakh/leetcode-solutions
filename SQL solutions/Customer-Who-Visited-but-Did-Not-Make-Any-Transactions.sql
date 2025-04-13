# Write your MySQL query statement below
select customer_id,count(visit_id) as count_no_trans from Visits where visit_id not in 
(select T.visit_id from Visits V, Transactions T where V.visit_id=T.visit_id)
group by customer_id