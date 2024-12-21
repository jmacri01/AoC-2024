<Query Kind="Program" />

void Main()
{
	var input = @"2333133121414131402";
	
	var fileBlockGenerator = new FileBlockGenerator();
	var fileBlocks = fileBlockGenerator.Generate(input);
fileBlocks.Dump();
	var diskDefragmenter = new DiskDefragmenter();
	diskDefragmenter.Defragment(fileBlocks);
//fileBlocks.Dump();
	var checksumGenerator = new ChecksumGenerator();
	checksumGenerator.Generate(fileBlocks).Dump();
}

public class ChecksumGenerator
{
	public double Generate(List<FileBlock> fileBlock)
	{
		double sum = 0;
		var position = 0;
		for(var i = 0; i < fileBlock.Count; ++i)
		{
			sum += (double)i * SumBlock(fileBlock[i], position);
			position += fileBlock[i].Size;
		}
		
		return sum;
	}
	
	private double SumBlock(FileBlock fileBlock, int position)
	{
		double sum = 0;
		for(var i = 0; i < fileBlock.Size; ++i)
		{
			sum += (double)(i + position) * (fileBlock.Id == "." ? 0 : double.Parse(fileBlock.Id));
		}
		
		return sum;
	}
}

public class DiskDefragmenter
{
//00...111...2...333.44.5555.6666.777.888899
	public void Defragment(List<FileBlock> fileBlocks)
	{
		var freeSpaceIndex = 0;
		var fileBlockIndex = fileBlocks.Count - 1;
		
		while (fileBlockIndex > freeSpaceIndex)
		{
			for (; freeSpaceIndex < fileBlocks.Count && fileBlocks[freeSpaceIndex].Id != "."; ++freeSpaceIndex);
			
			if (freeSpaceIndex >= fileBlocks.Count)
			{
				return;
			}
			
			for (; fileBlockIndex > 0 && (fileBlocks[fileBlockIndex].Id == "." || fileBlocks[fileBlockIndex].Size > fileBlocks[freeSpaceIndex].Size); --fileBlockIndex);
			
			if (fileBlockIndex < freeSpaceIndex)
			{
				return;
			}
			
			var fileBlockVal = fileBlocks[fileBlockIndex];
			var freeSpaceLeft = fileBlocks[freeSpaceIndex].Size - fileBlockVal.Size;
			
			fileBlockVal.Dump();
			fileBlockIndex.Dump();
			if (freeSpaceLeft > 0)
			{
				fileBlocks[freeSpaceIndex].Size = freeSpaceLeft;
				fileBlocks.Insert(freeSpaceIndex, new FileBlock
				{
					Id = fileBlockVal.Id,
					Size = fileBlockVal.Size,
				});
			}
			else
			{
				fileBlocks[freeSpaceIndex].Id = fileBlockVal.Id;
			}
			
			fileBlockVal.Id = ".";
			MergeFreeSpace(fileBlocks);
			fileBlockIndex = fileBlocks.Count - 1;
			freeSpaceIndex = 0;
			fileBlocks.Dump();
		}
	}
	
	private void MergeFreeSpace(List<FileBlock> fileBlocks)
	{
		for (var i = 0; i < fileBlocks.Count - 1; ++i)
		{
			if(fileBlocks.ElementAt(i).Id == "." && fileBlocks.ElementAt(i+1).Id == ".")
			{
				fileBlocks.ElementAt(i).Size += fileBlocks.ElementAt(i+1).Size;
				fileBlocks.RemoveAt(i+1);
				--i;
			}
		}
	}
}

public class FileBlockGenerator
{
	public List<FileBlock> Generate(string diskMap)
	{
		var fileBlocks = new List<FileBlock>();
		var blockId = 0;
		for(var i = 0; i < diskMap.Length; i+=2, blockId++)
		{
			var blockSize = int.Parse(diskMap[i].ToString());
			var freeSpaceSize = i > diskMap.Length - 2 ? 0 : int.Parse(diskMap[i+1].ToString());
			
			fileBlocks.Add(new FileBlock
			{
				Id = blockId.ToString(),
				Size = blockSize,
			});
			
			if (freeSpaceSize > 0)
			{
				fileBlocks.Add(new FileBlock
				{
					Id = ".",
					Size = freeSpaceSize,
				});
			}
		}
		
		return fileBlocks;
	}
}

public class FileBlock
{
	public string Id { get; set; }
	public int Size { get;set; }
}