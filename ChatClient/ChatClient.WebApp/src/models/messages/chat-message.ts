
export interface ChatMessage {
  messageRecipientId: number;
  messageId: number;
  authorName: string;
  textContent: string;
  isRead: boolean;
  isOwnMessage: boolean;
  createdAt: Date;
}

export interface ChatMessageDto {
  targetId: number;
  message: string;
}
