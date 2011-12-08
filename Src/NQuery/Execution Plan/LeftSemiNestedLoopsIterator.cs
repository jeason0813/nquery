using System;

namespace NQuery.Runtime.ExecutionPlan
{
	internal sealed class LeftSemiNestedLoopsIterator : NestedLoopsIterator
	{
		public override bool Read()
		{
			bool matchingRowFound = false;
			while (!matchingRowFound)
			{
				if (_advanceOuter)
				{
					_advanceOuter = false;

					if (!Left.Read())
						return false;

					if (CheckPassthruPredicate())
					{
						_advanceOuter = true;
						WriteLeftAndRightToRowBuffer();
						return true;
					}

					Right.Open();
				}

				// If we are bof or the inner is eof, reset the inner and
				// advance both cursors.
				if (_bof || !Right.Read())
				{
					_bof = false;
					_advanceOuter = true;
					continue;
				}

				// Check predicate.
				matchingRowFound = CheckPredicate();

				if (matchingRowFound)
					_advanceOuter = true;
			}

			WriteLeftAndRightToRowBuffer();
			return true;
		}
	}
}