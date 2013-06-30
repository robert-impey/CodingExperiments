-- Returns the penultimate element of a list
-- RFI 2010-05-11

penultimate xs = head(drop(length xs - 2) xs)
