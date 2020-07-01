using System.Numerics;

namespace Maple2.Trigger {
    public interface ITriggerContext {
        public TriggerState State { get; set; }

        #region Actions
        public void AddBalloonTalk(int spawnPointID = default, string msg = default, int duration = default,
            int delayTick = default, bool npcID = default);
        public void AddBuff(int[] arg1 = default, int arg2 = default, byte arg3 = default, bool arg4 = default,
            bool arg5 = default, string feature = default);
        public void AddCinematicTalk(int npcID = default, string illustID = default, string msg = default,
            int duration = default, string align = default, byte delayTick = default, string illust = default,
            int delay = default);
        public void AddEffectNif(int spawnPointID = default, string nifPath = default, bool isOutline = default,
            float scale = default, int rotateZ = default);
        public void AddUserValue(string key = default, int value = default);
        public void ArcadeBoomBoomOcean(string type = default, byte lifeCount = default, int id = default,
            int score = default, byte round = default, int roundDuration = default, int timeScoreRate = default);
        public void ArcadeSpringFarm(string type = default, byte lifeCount = default, int id = default,
            int score = default, int[] spawnID = default, int uiDuration = default, byte round = default,
            string timeScoreType = default, int timeScoreRate = default, int roundDuration = default);
        public void ArcadeThreeTwoOne(string type = default, byte lifeCount = default, int initScore = default,
            int uiDuration = default, bool round = default, byte resultDirection = default);
        public void ArcadeThreeTwoOne2(string type = default, byte lifeCount = default, int initScore = default,
            int uiDuration = default, bool round = default, byte resultDirection = default);
        public void ArcadeThreeTwoOne3(string type = default, byte lifeCount = default, int initScore = default,
            int uiDuration = default, bool round = default, byte resultDirection = default);
        public void ChangeBackground(string dds = default);
        public void ChangeMonster(int arg1 = default, int arg2 = default);
        public void CameraReset(float interpolationTime = default);
        public void CameraSelect(int arg1 = default, bool arg2 = default);
        public void CameraSelectPath(int[] arg1 = default, bool arg2 = default);
        public void CloseCinematic();
        public void CreateFieldGame(string type = default, bool reset = default);
        public void CreateItem(int[] arg1 = default, int arg2 = default, int arg3 = default, int arg5 = default);
        public void CreateMonster(int[] arg1 = default, bool arg2 = default, int arg3 = default);
        public void CreateWidget(string arg1 = default);
        public void DarkStream(string type = default, byte round = default, int uiDuration = default,
            byte damagePenalty = default, int[] spawnID = default, int score = default);
        public void DebugString(string value = default, string feature = default, string @string = default,
            string arg1 = default);
        public void DestroyMonster(int[] arg1 = default, bool arg2 = default);
        public void DungeonClear(string uiType = default);
        public void DungeonClearRound(byte round = default);
        public void DungeonCloseTimer();
        public void DungeonDisableRanking();
        public void DungeonEnableGiveUp(bool isEnable = default);
        public void DungeonFail();
        public void DungeonMissionComplete(string feature = default, int missionID = default);
        public void DungeonMoveLapTimeToNow(bool id = default);
        public void DungeonResetTime(int seconds = default);
        public void DungeonSetEndTime();
        public void DungeonSetLapTime(byte id = default, int lapTime = default);
        public void DungeonStopTimer();
        public void SetDungeonVariable(int varID = default, bool value = default);
        public void EnableLocalCamera(bool isEnable = default);
        public void EnableSpawnPointPc(int spawnPointID = default, bool isEnable = default);
        public void EndMiniGame(int winnerBoxId = default, string gameName = default, string isOnlyWinner = default);
        public void EndMiniGameRound(int winnerBoxId = default, float expRate = default, string isOnlyWinner = default,
            string isGainLoserBonus = default, bool meso = default, string gameName = default);
        public void FaceEmotion(int spawnPointID = default, string emotionName = default, bool spwnPointID = default);
        public void FieldGameConstant(string key = default, string value = default, string feature = default,
            string locale = default);
        public void FieldGameMessage(byte custom = default, string type = default, bool arg1 = default,
            string arg2 = default, int arg3 = default);
        public void FieldWarEnd(bool isClear = default);
        public void GiveExp(byte arg1 = default, byte arg2 = default);
        public void GiveGuildExp(bool boxID = default, byte type = default);
        public void GiveRewardContent(int rewardID = default);
        public void GuideEvent(int eventID = default);
        public void GuildVsGameEndGame();
        public void GuildVsGameGiveContribution(int teamID = default, string isWin = default, string desc = default);
        public void GuildVsGameGiveReward(string type = default, int teamID = default, string isWin = default,
            string desc = default);
        public void GuildVsGameLogResult(string desc = default);
        public void GuildVsGameLogWonByDefault(int teamID = default, string desc = default);
        public void GuildVsGameResult(string desc = default);
        public void GuildVsGameScoreByUser(int triggerBoxID = default, bool score = default, string desc = default);
        public void HideGuideSummary(int entityID = default, int textID = default);
        public void InitNpcRotation(int[] arg1 = default);
        public void KickMusicAudience(int targetBoxID = default, int targetPortalID = default);
        public void LimitSpawnNpcCount(byte limitCount = default, string desc = default);
        public void LockMyPc(bool isLock = default);
        public void MiniGameCameraDirection(int boxId = default, int cameraId = default);
        public void MiniGameGiveExp(int boxId = default, float expRate = default, string isOutSide = default);
        public void MiniGameGiveReward(int winnerBoxId = default, string contentType = default,
            string gameName = default);
        public void MoveNpc(int arg1 = default, string arg2 = default);
        public void MoveNpcToPos(int spawnPointID = default, Vector3 pos = default, Vector3 rot = default);
        public void MoveRandomUser(int arg1 = default, byte arg2 = default, int arg3 = default, byte arg4 = default);
        public void MoveToPortal(int userTagId = default, int portalId = default, int boxId = default);
        public void MoveUser(int arg1 = default, int arg2 = default, int arg3 = default);
        public void MoveUserPath(string arg1 = default);
        public void MoveUserToBox(int boxId = default, bool portalId = default);
        public void MoveUserToPos(Vector3 pos = default, Vector3 rot = default);
        public void Notice(bool arg1 = default, string arg2 = default, bool arg3 = default);
        public void NpcRemoveAdditionalEffect(int spawnPointID = default, int additionalEffectID = default);
        public void NpcToPatrolInBox(int boxId = default, int npcId = default, string spawnId = default,
            string patrolName = default);
        public void PatrolConditionUser(string patrolName = default, byte patrolIndex = default,
            int additionalEffectID = default);
        public void PlaySceneMovie(string fileName = default, int movieID = default, string skipType = default);
        public void PlaySystemSoundByUserTag(int userTagID = default, string soundKey = default);
        public void PlaySystemSoundInBox(string arg2 = default, int[] arg1 = default);
        public void RandomAdditionalEffect(string Target = default, int triggerBoxID = default,
            bool spawnPointID = default, bool targetCount = default, int tick = default, int waitTick = default,
            string targetEffect = default, int additionalEffectID = default);
        public void RemoveBalloonTalk(int spawnPointID = default);
        public void RemoveBuff(int arg1 = default, int arg2 = default, string arg3 = default);
        public void RemoveCinematicTalk();
        public void RemoveEffectNif(int spawnPointID = default);
        public void ResetTimer(string arg1 = default);
        public void RoomExpire();
        public void ScoreBoardCreate(string type = default, int maxScore = default);
        public void ScoreBoardRemove();
        public void ScoreBoardSetScore(bool score = default);
        public void SetAchievement(int arg1 = default, string arg2 = default, string arg3 = default);
        public void SetActor(int arg1 = default, bool arg2 = default, string arg3 = default, bool arg4 = default,
            bool arg5 = default);
        public void SetAgent(string arg1 = default, bool arg2 = default);
        public void SetAiExtraData(string key = default, int value = default, string isModify = default,
            int boxID = default);
        public void SetAmbientLight(Vector3 arg1 = default, Vector3 arg2 = default, Vector3 arg3 = default);
        public void SetCinematicIntro(string text = default);
        public void SetConversation(byte arg1 = default, int arg2 = default, string arg3 = default, int arg4 = default,
            byte arg5 = default, string align = default);
        public void SetCube(int[] IDs = default, bool isVisible = default, byte randomCount = default);
        public void SetDirectionalLight(Vector3 arg1 = default, Vector3 arg2 = default);
        public void SetEffect(int[] arg1 = default, bool arg2 = default, int arg3 = default, byte arg4 = default);
        public void SetEventUI(byte arg1 = default, string arg2 = default, int[] arg3 = default, string arg4 = default);
        public void SetGravity(float gravity = default);
        public void SetInteractObject(int[] arg1 = default, byte arg2 = default, bool arg4 = default,
            bool arg3 = default);
        public void SetLadder(int arg1 = default, bool arg2 = default, bool arg3 = default, byte arg4 = default);
        public void SetLocalCamera(int cameraId = default, bool enable = default);
        public void SetMesh(int[] arg1 = default, bool arg2 = default, int arg3 = default, int arg4 = default,
            float arg5 = default, string desc = default);
        public void SetMeshAnimation(int[] arg1 = default, bool arg2 = default, byte arg3 = default,
            byte arg4 = default);
        public void SetMiniGameAreaForHack(int boxID = default);
        public void SetBreakable(int[] arg1 = default, bool arg2 = default);
        public void SetNpcDuelHpBar(string isOpen = default, int spawnPointID = default, int durationTick = default,
            byte npcHpStep = default);
        public void SetNpcEmotionLoop(int arg1 = default, string arg2 = default, float arg3 = default);
        public void SetNpcEmotionSequence(int arg1 = default, string arg2 = default, int arg3 = default);
        public void SetNpcRotation(int arg1 = default, int arg2 = default);
        public void SetOnetimeEffect(int id = default, bool enable = default, string path = default);
        public void SetPcEmotionLoop(string arg1 = default, float arg2 = default, bool arg3 = default);
        public void SetPcEmotionSequence(string arg1 = default);
        public void SetPcRotation(Vector3 rotation = default);
        public void SetPhotoStudio(bool isEnable = default);
        public void SetPortal(int arg1 = default, bool arg2 = default, bool arg3 = default, bool arg4 = default,
            bool arg5 = default);
        public void SetProductionUI(byte arg1 = default, string arg2 = default, bool arg3 = default);
        public void SetPvpZone(byte arg1 = default, byte arg2 = default, int arg3 = default, int arg4 = default,
            byte arg5 = default, byte[] arg6 = default);
        public void SetQuestAccept(int questID = default, int arg1 = default);
        public void SetQuestComplete(int questID = default);
        public void SetRandomMesh(int[] arg1 = default, bool arg2 = default, byte arg3 = default, int arg4 = default,
            int arg5 = default);
        public void SetRope(int arg1 = default, bool arg2 = default, bool arg3 = default, byte arg4 = default);
        public void SetSceneSkip(string arg1 = default, string arg2 = default);
        public void SetSkill(int[] arg1 = default, bool arg2 = default);
        public void SetSkip(string arg1 = default);
        public void SetSound(int arg1 = default, bool arg2 = default);
        public void SetState(byte arg1 = default, string arg2 = default, bool arg3 = default);
        public void SetTimer(string arg1 = default, int arg2 = default, bool arg3 = default, bool arg4 = default,
            int arg5 = default, string arg6 = default, string desc = default);
        public void SetTimeScale(bool enable = default, float startScale = default, float endScale = default,
            float duration = default, byte interpolator = default);
        public void SetUserValue(int triggerID = default, string key = default, int value = default);
        public void SetUserValueFromDungeonRewardCount(string key = default, int dungeonRewardID = default);
        public void SetUserValueFromGuildVsGameScore(int teamID = default, string key = default);
        public void SetUserValueFromUserCount(int triggerBoxID = default, string key = default,
            int userTagID = default);
        public void SetVisibleBreakableObject(int[] arg1 = default, bool arg2 = default);
        public void SetVisibleUI(string uiName = default, bool visible = default);
        public void ShadowExpedition(string type = default, int maxGaugePoint = default, string title = default);
        public void ShowCaption(string type = default, string title = default, string desc = default,
            string align = default, float offsetRateX = default, float offsetRateY = default, int duration = default,
            float scale = default);
        public void ShowCountUI(string text = default, byte stage = default, byte count = default,
            byte soundType = 1);
        public void ShowEventResult(string type = default, string text = default, int duration = default,
            int userTagID = default, int triggerBoxID = default, bool isOutSide = default);
        public void ShowGuideSummary(int entityID = default, int textID = default, int duration = default);
        public void ShowRoundUI(byte round = default, int duration = default);
        public void SideNpcTalk(int npcID = default, string illust = default, int duration = default,
            string script = default, string voice = default, string type = default, string usm = default);
        public void SightRange(bool enable = default, byte range = default, int rangeZ = default,
            byte border = default);
        public void SpawnItemRange(int[] rangeID = default, byte randomPickCount = default);
        public void SpawnNpcRange(int[] rangeID = default, bool isAutoTargeting = default,
            byte randomPickCount = default, int score = default);
        public void StartCombineSpawn(int[] groupId = default, string isStart = default);
        public void StartMiniGame(int boxId = default, byte round = default, string gameName = default,
            string isShowResultUI = default);
        public void StartMiniGameRound(int boxId = default, byte round = default);
        public void StartTutorial();
        public void TalkNpc(int spawnPointID = default);
        public void UnSetMiniGameAreaForHack();
        public void UserTagSymbol(string symbol1 = default, string symbol2 = default);
        public void UserValueToNumberMesh(string key = default, int startMeshID = default, byte digitCount = default);
        public void UseState(byte arg1 = default, bool arg2 = default);
        public void VisibleMyPc(bool isVisible = default);
        public void Weather(string weatherType = default);
        public void WeddingBroken();
        public void WeddingMoveUser(string entryType = default, int arg1 = default, byte[] arg2 = default,
            int arg3 = default);
        public void WeddingMutualAgree(string agreeType = default);
        public void WeddingMutualCancel(string agreeType = default);
        public void WeddingSetUserEmotion(string entryType = default, byte id = default);
        public void WeddingSetUserLookAt(string entryType = default, string lookAtEntryType = default,
            bool immediate = default);
        public void WeddingSetUserRotation(string entryType = default, Vector3 rotation = default,
            bool immediate = default);
        public void WeddingUserToPatrol(string patrolName = default, string entryType = default,
            byte patrolIndex = default);
        public void WeddingVowComplete();
        public void WidgetAction(string arg1 = default, string arg2 = default, string arg3 = default,
            string desc = default, int widgetArgNum = default);
        public void WriteLog(string arg1 = default, string arg3 = default, int arg2 = default, string arg5 = default,
            byte arg4 = default);
        #endregion

        #region Conditions
        // public bool AllOf(string feature = default);
        // public bool AnyOne();
        public bool BonusGameRewardDetected(byte arg1 = default, bool arg2 = default);
        public bool CheckAnyUserAdditionalEffect(int triggerBoxID = default, int additionalEffectID = default,
            bool level = default);
        public bool CheckDungeonLobbyUserCount();
        public bool CheckNpcAdditionalEffect(int spawnPointID = default, int additionalEffectID = default,
            byte level = default);
        public bool CheckNpcDamage(int spawnPointID = default, float damageRate = default, string @operator = default);
        public bool CheckNpcExtraData(int spawnPointID = default, string extraDataKey = default,
            int extraDataValue = default, string @operator = default);
        public bool CheckNpcHp(string compare = default, byte value = default, int spawnPointId = default,
            string isRelative = default);
        public bool CheckSameUserTag(int triggerBoxID = default);
        public bool CheckUser();
        public bool CheckUserCount(byte checkCount = default);
        public bool CountUsers(int arg1 = default, byte arg2 = default, string arg3 = default, int userTagID = default);
        public bool DayOfWeek(byte[] dayOfWeeks = default, string desc = default);
        public bool DetectLiftableObject(int[] triggerBoxIDs = default, int itemID = default);
        public bool DungeonCheckPlayTime(int playSeconds = default, string @operator = default);
        public bool DungeonCheckState(string checkState = default);
        public bool DungeonFirstUserMissionScore(int score = default, string @operator = default);
        public bool DungeonID(int dungeonID = default);
        public bool DungeonLevel(byte level = default);
        public bool DungeonMaxUserCount(byte value = default);
        public bool DungeonRoundRequire(byte round = default);
        public bool DungeonTimeOut();
        public bool DungeonVariable(int varID = default, bool value = default);
        public bool GuildVsGameScoredTeam(int teamID = default);
        public bool GuildVsGameWinnerTeam(int teamID = default);
        public bool IsDungeonRoom();
        public bool IsPlayingMapleSurvival();
        public bool MonsterDead(int[] arg1 = default, bool arg2 = default);
        public bool MonsterInCombat(int[] arg1 = default);
        public bool NpcDetected(int arg1 = default, int[] arg2 = default);
        public bool NpcIsDeadByStringID(string stringID = default);
        public bool ObjectInteracted(int[] arg1 = default, byte arg2 = default);
        public bool PvpZoneEnded(byte arg1 = default);
        public bool QuestUserDetected(int[] arg1 = default, int[] arg2 = default, byte[] arg3 = default,
            byte arg4 = default);
        public bool RandomCondition(float arg1 = default, string desc = default);
        public bool ScoreBoardCompare(string compareOp = default, int score = default);
        public bool ShadowExpeditionReachPoint(int point = default);
        public bool TimeExpired(string arg1 = default);
        // public bool True(bool arg1 = default);
        public bool UserDetected(int[] arg1 = default, byte arg2 = default);
        public bool UserValue(string key = default, int value = default, string @operator = default);
        public bool WaitAndResetTick(int waitTick = default);
        public bool WaitSecondsUserValue(string key = default, string desc = default);
        public bool WaitTick(int waitTick = default, int arg1 = default);
        public bool WeddingEntryInField(string entryType = default, bool isInField = default);
        public bool WeddingHallState(string hallState = default, bool success = default);
        public bool WeddingMutualAgreeResult(string agreeType = default, bool success = default);
        public bool WidgetCondition(string arg1 = default, string arg2 = default, string arg3 = default,
            string desc = default);
        #endregion
    }
}