using System.Numerics;

namespace Maple2.Trigger {
    public interface ITriggerContext {
        public TriggerState State { get; set; }

        #region Actions
        public void AddBalloonTalk(int spawnPointId = 0, string msg = "", int duration = 0, int delayTick = 0,
            bool npcId = false);
        public void AddBuff(int[] arg1 = default, int arg2 = 0, byte arg3 = 0, bool arg4 = false, bool arg5 = false,
            string feature = "");
        public void AddCinematicTalk(int npcId = 0, string illustId = "", string msg = "", int duration = 0,
            string align = "", byte delayTick = 0, string illust = "", int delay = 0);
        public void AddEffectNif(int spawnPointId = 0, string nifPath = "", bool isOutline = false, float scale = 0f,
            int rotateZ = 0);
        public void AddUserValue(string key = "", int value = 0);
        public void ArcadeBoomBoomOcean(string type = "", byte lifeCount = 0, int id = 0, int score = 0, byte round = 0,
            int roundDuration = 0, int timeScoreRate = 0);
        public void ArcadeSpringFarm(string type = "", byte lifeCount = 0, int id = 0, int score = 0,
            int[] spawnId = default, int uiDuration = 0, byte round = 0, string timeScoreType = "",
            int timeScoreRate = 0, int roundDuration = 0);
        public void ArcadeThreeTwoOne(string type = "", byte lifeCount = 0, int initScore = 0, int uiDuration = 0,
            bool round = false, byte resultDirection = 0);
        public void ArcadeThreeTwoOne2(string type = "", byte lifeCount = 0, int initScore = 0, int uiDuration = 0,
            bool round = false, byte resultDirection = 0);
        public void ArcadeThreeTwoOne3(string type = "", byte lifeCount = 0, int initScore = 0, int uiDuration = 0,
            bool round = false, byte resultDirection = 0);
        public void ChangeBackground(string dds = "");
        public void ChangeMonster(int arg1 = 0, int arg2 = 0);
        public void CameraReset(float interpolationTime = 0f);
        public void CameraSelect(int arg1 = 0, bool arg2 = false);
        public void CameraSelectPath(int[] arg1 = default, bool arg2 = false);
        public void CloseCinematic();
        public void CreateFieldGame(string type = "", bool reset = false);
        public void CreateItem(int[] arg1 = default, int arg2 = 0, int arg3 = 0, int arg5 = 0);
        public void CreateMonster(int[] arg1 = default, bool arg2 = false, int arg3 = 0);
        public void CreateWidget(string arg1 = "");
        public void DarkStream(string type = "", byte round = 0, int uiDuration = 0, byte damagePenalty = 0,
            int[] spawnId = default, int score = 0);
        public void DebugString(string value = "", string feature = "", string message = "", string arg1 = "");
        public void DestroyMonster(int[] arg1 = default, bool arg2 = false);
        public void DungeonClear(string uiType = "");
        public void DungeonClearRound(byte round = 0);
        public void DungeonCloseTimer();
        public void DungeonDisableRanking();
        public void DungeonEnableGiveUp(bool isEnable = false);
        public void DungeonFail();
        public void DungeonMissionComplete(string feature = "", int missionId = 0);
        public void DungeonMoveLapTimeToNow(bool id = false);
        public void DungeonResetTime(int seconds = 0);
        public void DungeonSetEndTime();
        public void DungeonSetLapTime(byte id = 0, int lapTime = 0);
        public void DungeonStopTimer();
        public void SetDungeonVariable(int varId = 0, bool value = false);
        public void EnableLocalCamera(bool isEnable = false);
        public void EnableSpawnPointPc(int spawnPointId = 0, bool isEnable = false);
        public void EndMiniGame(int winnerBoxId = 0, string gameName = "", bool isOnlyWinner = false);
        public void EndMiniGameRound(int winnerBoxId = 0, float expRate = 0f, bool isOnlyWinner = false,
            bool isGainLoserBonus = false, bool meso = false, string gameName = "");
        public void FaceEmotion(int spawnPointId = 0, string emotionName = "", bool spwnPointId = false);
        public void FieldGameConstant(string key = "", string value = "", string feature = "", string locale = "");
        public void FieldGameMessage(byte custom = 0, string type = "", byte arg1 = 0, string arg2 = "",
            int arg3 = 0);
        public void FieldWarEnd(bool isClear = false);
        public void GiveExp(byte arg1 = 0, byte arg2 = 0);
        public void GiveGuildExp(bool boxId = false, byte type = 0);
        public void GiveRewardContent(int rewardId = 0);
        public void GuideEvent(int eventId = 0);
        public void GuildVsGameEndGame();
        public void GuildVsGameGiveContribution(int teamId = 0, bool isWin = false, string desc = "");
        public void GuildVsGameGiveReward(string type = "", int teamId = 0, bool isWin = false, string desc = "");
        public void GuildVsGameLogResult(string desc = "");
        public void GuildVsGameLogWonByDefault(int teamId = 0, string desc = "");
        public void GuildVsGameResult(string desc = "");
        public void GuildVsGameScoreByUser(int triggerBoxId = 0, bool score = false, string desc = "");
        public void HideGuideSummary(int entityId = 0, int textId = 0);
        public void InitNpcRotation(int[] arg1 = default);
        public void KickMusicAudience(int targetBoxId = 0, int targetPortalId = 0);
        public void LimitSpawnNpcCount(byte limitCount = 0);
        public void LockMyPc(bool isLock = false);
        public void MiniGameCameraDirection(int boxId = 0, int cameraId = 0);
        public void MiniGameGiveExp(int boxId = 0, float expRate = 0f, string isOutSide = "");
        public void MiniGameGiveReward(int winnerBoxId = 0, string contentType = "", string gameName = "");
        public void MoveNpc(int arg1 = 0, string arg2 = "");
        public void MoveNpcToPos(int spawnPointId = 0, Vector3 pos = default, Vector3 rot = default);
        public void MoveRandomUser(int arg1 = 0, byte arg2 = 0, int arg3 = 0, byte arg4 = 0);
        public void MoveToPortal(int userTagId = 0, int portalId = 0, int boxId = 0);
        public void MoveUser(int arg1 = 0, int arg2 = 0, int arg3 = 0);
        public void MoveUserPath(string arg1 = "");
        public void MoveUserToBox(int boxId = 0, bool portalId = false);
        public void MoveUserToPos(Vector3 pos = default, Vector3 rot = default);
        public void Notice(bool arg1 = false, string arg2 = "", bool arg3 = false);
        public void NpcRemoveAdditionalEffect(int spawnPointId = 0, int additionalEffectId = 0);
        public void NpcToPatrolInBox(int boxId = 0, int npcId = 0, string spawnId = "", string patrolName = "");
        public void PatrolConditionUser(string patrolName = "", byte patrolIndex = 0, int additionalEffectId = 0);
        public void PlaySceneMovie(string fileName = "", int movieId = 0, string skipType = "");
        public void PlaySystemSoundByUserTag(int userTagId = 0, string soundKey = "");
        public void PlaySystemSoundInBox(string arg2 = "", int[] arg1 = default);
        public void RandomAdditionalEffect(string target = "", int triggerBoxId = 0, bool spawnPointId = false,
            bool targetCount = false, int tick = 0, int waitTick = 0, string targetEffect = "",
            int additionalEffectId = 0);
        public void RemoveBalloonTalk(int spawnPointId = 0);
        public void RemoveBuff(int arg1 = 0, int arg2 = 0, bool arg3 = false);
        public void RemoveCinematicTalk();
        public void RemoveEffectNif(int spawnPointId = 0);
        public void ResetTimer(string arg1 = "");
        public void RoomExpire();
        public void ScoreBoardCreate(string type = "", int maxScore = 0);
        public void ScoreBoardRemove();
        public void ScoreBoardSetScore(bool score = false);
        public void SetAchievement(int arg1 = 0, string arg2 = "", string arg3 = "");
        public void SetActor(int arg1 = 0, bool arg2 = false, string arg3 = "", bool arg4 = false, bool arg5 = false);
        public void SetAgent(string arg1 = "", bool arg2 = false);
        public void SetAiExtraData(string key = "", int value = 0, bool isModify = false, int boxId = 0);
        public void SetAmbientLight(Vector3 arg1 = default, Vector3 arg2 = default, Vector3 arg3 = default);
        public void SetCinematicIntro(string text = "");
        public void SetConversation(byte arg1 = 0, int arg2 = 0, string arg3 = "", int arg4 = 0, byte arg5 = 0,
            string align = "");
        public void SetCube(int[] ids = default, bool isVisible = false, byte randomCount = 0);
        public void SetDirectionalLight(Vector3 arg1 = default, Vector3 arg2 = default);
        public void SetEffect(int[] arg1 = default, bool arg2 = false, int arg3 = 0, byte arg4 = 0);
        public void SetEventUI(byte arg1 = 0, string arg2 = "", int arg3 = 0, string arg4 = "");
        public void SetGravity(float gravity = 0f);
        public void SetInteractObject(int[] arg1 = default, byte arg2 = 0, bool arg4 = false, bool arg3 = false);
        public void SetLadder(int arg1 = 0, bool arg2 = false, bool arg3 = false, byte arg4 = 0);
        public void SetLocalCamera(int cameraId = 0, bool enable = false);
        public void SetMesh(int[] arg1 = default, bool arg2 = false, int arg3 = 0, int arg4 = 0, float arg5 = 0f);
        public void SetMeshAnimation(int[] arg1 = default, bool arg2 = false, byte arg3 = 0, byte arg4 = 0);
        public void SetMiniGameAreaForHack(int boxId = 0);
        public void SetBreakable(int[] arg1 = default, bool arg2 = false);
        public void SetNpcDuelHpBar(bool isOpen = false, int spawnPointId = 0, int durationTick = 0,
            byte npcHpStep = 0);
        public void SetNpcEmotionLoop(int arg1 = 0, string arg2 = "", float arg3 = 0f);
        public void SetNpcEmotionSequence(int arg1 = 0, string arg2 = "", int arg3 = 0);
        public void SetNpcRotation(int arg1 = 0, int arg2 = 0);
        public void SetOnetimeEffect(int id = 0, bool enable = false, string path = "");
        public void SetPcEmotionLoop(string arg1 = "", float arg2 = 0f, bool arg3 = false);
        public void SetPcEmotionSequence(string arg1 = "");
        public void SetPcRotation(Vector3 rotation = default);
        public void SetPhotoStudio(bool isEnable = false);
        public void SetPortal(int arg1 = 0, bool arg2 = false, bool arg3 = false, bool arg4 = false, bool arg5 = false);
        public void SetProductionUI(byte arg1 = 0, string arg2 = "", bool arg3 = false);
        public void SetPvpZone(byte arg1 = 0, byte arg2 = 0, int arg3 = 0, int arg4 = 0, byte arg5 = 0,
            byte[] arg6 = default);
        public void SetQuestAccept(int questId = 0, int arg1 = 0);
        public void SetQuestComplete(int questId = 0);
        public void SetRandomMesh(int[] arg1 = default, bool arg2 = false, byte arg3 = 0, int arg4 = 0, int arg5 = 0);
        public void SetRope(int arg1 = 0, bool arg2 = false, bool arg3 = false, byte arg4 = 0);
        public void SetSceneSkip(string arg1 = "", string arg2 = "");
        public void SetSkill(int[] arg1 = default, bool arg2 = false);
        public void SetSkip(string arg1 = "");
        public void SetSound(int arg1 = 0, bool arg2 = false);
        public void SetState(byte arg1 = 0, string arg2 = "", bool arg3 = false);
        public void SetTimer(string arg1 = "", int arg2 = 0, bool arg3 = false, bool arg4 = false, int arg5 = 0,
            string arg6 = "");
        public void SetTimeScale(bool enable = false, float startScale = 0f, float endScale = 0f, float duration = 0f,
            byte interpolator = 0);
        public void SetUserValue(int triggerId = 0, string key = "", int value = 0);
        public void SetUserValueFromDungeonRewardCount(string key = "", int dungeonRewardId = 0);
        public void SetUserValueFromGuildVsGameScore(int teamId = 0, string key = "");
        public void SetUserValueFromUserCount(int triggerBoxId = 0, string key = "", int userTagId = 0);
        public void SetVisibleBreakableObject(int[] arg1 = default, bool arg2 = false);
        public void SetVisibleUI(string uiName = "", bool visible = false);
        public void ShadowExpedition(string type = "", int maxGaugePoint = 0, string title = "");
        public void ShowCaption(string type = "", string title = "", string desc = "", string align = "",
            float offsetRateX = 0f, float offsetRateY = 0f, int duration = 0, float scale = 0f);
        public void ShowCountUI(string text = "", byte stage = 0, byte count = 0, byte soundType = 1);
        public void ShowEventResult(string type = "", string text = "", int duration = 0, int userTagId = 0,
            int triggerBoxId = 0, bool isOutSide = false);
        public void ShowGuideSummary(int entityId = 0, int textId = 0, int duration = 0);
        public void ShowRoundUI(byte round = 0, int duration = 0);
        public void SideNpcTalk(int npcId = 0, string illust = "", int duration = 0, string script = "",
            string voice = "", string type = "", string usm = "");
        public void SightRange(bool enable = false, byte range = 0, int rangeZ = 0, byte border = 0);
        public void SpawnItemRange(int[] rangeId = default, byte randomPickCount = 0);
        public void SpawnNpcRange(int[] rangeId = default, bool isAutoTargeting = false, byte randomPickCount = 0,
            int score = 0);
        public void StartCombineSpawn(int[] groupId = default, bool isStart = false);
        public void StartMiniGame(int boxId = 0, byte round = 0, string gameName = "", string isShowResultUI = "");
        public void StartMiniGameRound(int boxId = 0, byte round = 0);
        public void StartTutorial();
        public void TalkNpc(int spawnPointId = 0);
        public void UnSetMiniGameAreaForHack();
        public void UserTagSymbol(string symbol1 = "", string symbol2 = "");
        public void UserValueToNumberMesh(string key = "", int startMeshId = 0, byte digitCount = 0);
        public void UseState(byte arg1 = 0, bool arg2 = false);
        public void VisibleMyPc(bool isVisible = false);
        public void Weather(string weatherType = "");
        public void WeddingBroken();
        public void WeddingMoveUser(string entryType = "", int arg1 = 0, byte[] arg2 = default, int arg3 = 0);
        public void WeddingMutualAgree(string agreeType = "");
        public void WeddingMutualCancel(string agreeType = "");
        public void WeddingSetUserEmotion(string entryType = "", byte id = 0);
        public void WeddingSetUserLookAt(string entryType = "", string lookAtEntryType = "", bool immediate = false);
        public void WeddingSetUserRotation(string entryType = "", Vector3 rotation = default, bool immediate = false);
        public void WeddingUserToPatrol(string patrolName = "", string entryType = "", byte patrolIndex = 0);
        public void WeddingVowComplete();
        public void WidgetAction(string arg1 = "", string arg2 = "", string arg3 = "", int widgetArgNum = 0);
        public void WriteLog(string arg1 = "", string arg3 = "", int arg2 = 0, string arg5 = "", byte arg4 = 0);
        #endregion

        #region Conditions
        public bool BonusGameRewardDetected(byte arg1 = 0, bool arg2 = false);
        public bool CheckAnyUserAdditionalEffect(int triggerBoxId = 0, int additionalEffectId = 0, bool level = false);
        public bool CheckDungeonLobbyUserCount();
        public bool CheckNpcAdditionalEffect(int spawnPointId = 0, int additionalEffectId = 0, byte level = 0);
        public bool CheckSameUserTag(int triggerBoxId = 0);
        public bool DayOfWeek(byte[] dayOfWeeks = default, string desc = "");
        public bool DetectLiftableObject(int[] triggerBoxIds = default, int itemId = 0);
        public bool DungeonTimeOut();
        public bool GuildVsGameScoredTeam(int teamId = 0);
        public bool GuildVsGameWinnerTeam(int teamId = 0);
        public bool IsDungeonRoom();
        public bool IsPlayingMapleSurvival();
        public bool MonsterDead(int[] arg1 = default, bool arg2 = false);
        public bool MonsterInCombat(int[] arg1 = default);
        public bool NpcDetected(int arg1 = 0, int[] arg2 = default);
        public bool NpcIsDeadByStringId(string stringId = "");
        public bool ObjectInteracted(int[] arg1 = default, byte arg2 = 0);
        public bool PvpZoneEnded(byte arg1 = 0);
        public bool QuestUserDetected(int[] arg1 = default, int[] arg2 = default, byte[] arg3 = default, byte arg4 = 0);
        public bool RandomCondition(float arg1 = 0f, string desc = "");
        public bool TimeExpired(string arg1 = "");
        public bool UserDetected(int[] arg1 = default, byte arg2 = 0);
        public bool WaitAndResetTick(int waitTick = 0);
        public bool WaitTick(int waitTick = 0);
        public bool WeddingEntryInField(string entryType = "", bool isInField = false);
        public bool WeddingHallState(string hallState = "", bool success = false);
        public bool WeddingMutualAgreeResult(string agreeType = "", bool success = false);
        public bool WidgetCondition(string arg1 = "", string arg2 = "", string arg3 = "");
        #endregion

        #region Getters
        public int GetDungeonFirstUserMissionScore();
        public int GetDungeonId();
        public int GetDungeonLevel();
        public int GetDungeonMaxUserCount();
        public int GetDungeonPlayTime();
        public int GetDungeonRoundsRequired();
        public string GetDungeonState();
        public bool GetDungeonVariable(int id);
        public float GetNpcDamageRate(int spawnPointId);
        public int GetNpcExtraData(int spawnPointId, string extraDataKey);
        public float GetNpcHpRate(int spawnPointId);
        public int GetScoreBoardScore();
        public int GetShadowExpeditionPoints();
        public int GetUserCount(int boxId = -1, int userTagId = 0);
        public int GetUserValue(string key);
        #endregion
    }
}