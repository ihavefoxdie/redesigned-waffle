namespace Task2;

public class Counter
{
    private int count = 0;
    private ReaderWriterLockSlim _readWriteLock = new();
    public int GetCount
    {
        get
        {
            _readWriteLock.EnterReadLock();
            try
            {
                return count;
            }
            finally
            {
                _readWriteLock.ExitReadLock();
            }
        }
    }

    public int AddToCount
    {
        set
        {
            _readWriteLock.EnterWriteLock();
            try
            {
                count += value;
            }
            finally
            {
                _readWriteLock.ExitWriteLock();
            }
        }
    }
}
