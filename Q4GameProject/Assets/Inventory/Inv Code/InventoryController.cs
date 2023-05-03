using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour
{
    [HideInInspector]
    private ItemGrid selectedItemGrid;

    public ItemGrid SelectedItemGrid { 
        get => selectedItemGrid;
        set {
            selectedItemGrid = value;
            inventoryHighlight.SetParent(value);
        }
    }

    InventoryItem selectedItem;
    InventoryItem overlapItem;
    RectTransform rectTransform;
    public Text itemName;
    public int BatteryTaken = 0;
    public int ToothpasteTaken = 0;
    public int KeyTaken = 0;

    [SerializeField] List<ItemData> items;
    [SerializeField] GameObject itemPrefab;
    [SerializeField] Transform canvasTransform;

    InventoryHighlight inventoryHighlight;

    InventoryItem inventoryItem;

    private void Awake()
    {
        inventoryHighlight = GetComponent<InventoryHighlight>();
    }

    public void Start()
    {
        BatteryTaken = PlayerPrefs.GetInt("BatteryTaken");
        ToothpasteTaken = PlayerPrefs.GetInt("ToothpasteTaken");
        KeyTaken = PlayerPrefs.GetInt("KeyTaken");
    }

    public void Update()
    {
        BatteryTaken = PlayerPrefs.GetInt("BatteryTaken");
        ToothpasteTaken = PlayerPrefs.GetInt("ToothpasteTaken");
        KeyTaken = PlayerPrefs.GetInt("KeyTaken");
        ItemIconDrag();

        if (selectedItem == null)
        {
            if (BatteryTaken == 1 || Input.GetKeyDown(KeyCode.Keypad1))
            {
                InventoryItem inventoryItem = Instantiate(itemPrefab).GetComponent<InventoryItem>();
                selectedItem = inventoryItem;

                rectTransform = inventoryItem.GetComponent<RectTransform>();
                rectTransform.SetParent(canvasTransform);

                int selectedItemID = 0;
                inventoryItem.Set(items[selectedItemID]);
                PlayerPrefs.SetInt("BatteryTaken", 1);
            }
            else if (ToothpasteTaken == 1 || Input.GetKeyDown(KeyCode.Keypad2))
            {
                InventoryItem inventoryItem = Instantiate(itemPrefab).GetComponent<InventoryItem>();
                selectedItem = inventoryItem;

                rectTransform = inventoryItem.GetComponent<RectTransform>();
                rectTransform.SetParent(canvasTransform);

                int selectedItemID = 1;
                inventoryItem.Set(items[selectedItemID]);
                PlayerPrefs.SetInt("ToothpasteTaken", 1);
            }
            else if (KeyTaken == 1 || Input.GetKeyDown(KeyCode.Keypad3))
            {
                InventoryItem inventoryItem = Instantiate(itemPrefab).GetComponent<InventoryItem>();
                selectedItem = inventoryItem;

                rectTransform = inventoryItem.GetComponent<RectTransform>();
                rectTransform.SetParent(canvasTransform);

                int selectedItemID = 2;
                inventoryItem.Set(items[selectedItemID]);
                PlayerPrefs.SetInt("KeyTaken", 1);
            }
        }
        else
        {
            if (selectedItem.itemData.id == 0)
            {
                itemName.text = string.Format("{0}", selectedItem.itemData.itemName);
            }
            else if (selectedItem.itemData.id == 1)
            {
                itemName.text = string.Format("{0}", selectedItem.itemData.itemName);
            }
            else if (selectedItem.itemData.id == 2)
            {
                itemName.text = string.Format("{0}", selectedItem.itemData.itemName);
            }
            else if (selectedItem.itemData.id == 3)
            {
                itemName.text = string.Format("{0}", selectedItem.itemData.itemName);
            }
        }

        if (selectedItemGrid == null) 
        {
            inventoryHighlight.Show(false);
            return; 
        }

        HandleHighlight(); 

        if (Input.GetMouseButtonDown(0))
        {
            LeftMouseButtonPress();

        }
    }

    Vector2Int oldPosition;
    InventoryItem itemToHighlight;

    private void HandleHighlight()
    {
        Vector2Int positionOnGrid = GetTileGridPosition();
        if(oldPosition == positionOnGrid)
        {
            return;
        }

        oldPosition = positionOnGrid;
        if (selectedItem == null)
        {
            itemToHighlight = selectedItemGrid.GetItem(positionOnGrid.x, positionOnGrid.y);

            if (itemToHighlight != null)
            {
                inventoryHighlight.Show(true);
                inventoryHighlight.SetSize(itemToHighlight);
                inventoryHighlight.SetPosition(selectedItemGrid, itemToHighlight);
            }
            else
            {
                inventoryHighlight.Show(false);
            }
        }
        else
        {
            inventoryHighlight.Show(selectedItemGrid.BoundryCheck(
                positionOnGrid.x, 
                positionOnGrid.y, 
                selectedItem.itemData.width,
                selectedItem.itemData.height));

            inventoryHighlight.SetSize(selectedItem);
            inventoryHighlight.SetPosition(selectedItemGrid, selectedItem, positionOnGrid.x, positionOnGrid.y);
        }
    }

    private void CreateRandomItem()
    {
        //nothing
    }

    private void LeftMouseButtonPress()
    {
        Vector2Int tileGridPosition = GetTileGridPosition();

        if (selectedItem == null)
        {
            PickUpItem(tileGridPosition);
        }
        else
        {
            PlaceItem(tileGridPosition);
        }
    }

    private Vector2Int GetTileGridPosition()
    {
        Vector2 position = Input.mousePosition;

        if (selectedItem != null)
        {
            position.x -= (selectedItem.itemData.width - 1) * ItemGrid.tileSizeWidth / 2;
            position.y += (selectedItem.itemData.height - 1) * ItemGrid.tileSizeHeight / 2;
        }

        return selectedItemGrid.GetTileGridPosition(position);
    }

    public void PlaceItem(Vector2Int tileGridPosition)
    {
        bool complete = selectedItemGrid.PlaceItem(selectedItem, tileGridPosition.x, tileGridPosition.y, ref overlapItem);
        if (complete && BatteryTaken == 1)
        {
            PlayerPrefs.SetInt("BatteryTaken", 0);
            PlayerPrefs.SetInt("HasBattery", 1);
            Debug.Log(PlayerPrefs.GetInt("HasBattery"));
            PlayerPrefs.SetInt("BatteryID", selectedItem.id);
            selectedItem = null;
            if(overlapItem != null)
            {
                selectedItem = overlapItem;
                overlapItem = null;
                rectTransform = selectedItem.GetComponent<RectTransform>();
                if (selectedItem.itemData.id == 2)
                {
                    PlayerPrefs.SetInt("BatteryTaken", 1);
                }
                else if (selectedItem.itemData.id == 3)
                {
                    PlayerPrefs.SetInt("ToothpasteTaken", 1);
                }
                else if (selectedItem.itemData.id == 4)
                {
                    PlayerPrefs.SetInt("KeyTaken", 1);
                }
            }
        }
        else if (complete && ToothpasteTaken == 1)
        {
            PlayerPrefs.SetInt("ToothpasteTaken", 0);
            PlayerPrefs.SetInt("HasToothpaste", 1);
            selectedItem = null;
            if (overlapItem != null)
            {
                selectedItem = overlapItem;
                overlapItem = null;
                rectTransform = selectedItem.GetComponent<RectTransform>();
                if (selectedItem.itemData.id == 2)
                {
                    PlayerPrefs.SetInt("BatteryTaken", 1);
                }
                else if (selectedItem.itemData.id == 3)
                {
                    PlayerPrefs.SetInt("ToothpasteTaken", 1);
                }
                else if (selectedItem.itemData.id == 4)
                {
                    PlayerPrefs.SetInt("KeyTaken", 1);
                }
            }
        }
        else if (complete && KeyTaken == 1)
        {
            PlayerPrefs.SetInt("KeyTaken", 0);
            PlayerPrefs.SetInt("HasKey", 1);
            selectedItem = null;
            if (overlapItem != null)
            {
                selectedItem = overlapItem;
                overlapItem = null;
                rectTransform = selectedItem.GetComponent<RectTransform>();
                if (selectedItem.itemData.id == 2)
                {
                    PlayerPrefs.SetInt("BatteryTaken", 1);
                }
                else if (selectedItem.itemData.id == 3)
                {
                    PlayerPrefs.SetInt("ToothpasteTaken", 1);
                }
                else if (selectedItem.itemData.id == 4)
                {
                    PlayerPrefs.SetInt("KeyTaken", 1);
                }
            }
        }
        if (complete == false)
        {
            if (selectedItem.itemData.id == 2)
            {
                PlayerPrefs.SetInt("BatteryTaken", 1);
            }
            else if (selectedItem.itemData.id == 3)
            {
                PlayerPrefs.SetInt("ToothpasteTaken", 1);
            }
            else if (selectedItem.itemData.id == 4)
            {
                PlayerPrefs.SetInt("KeyTaken", 1);
            }
            selectedItem.itemData = null;
        }
    }

    private void PickUpItem(Vector2Int tileGridPosition)
    {
        selectedItem = selectedItemGrid.PickUpItem(tileGridPosition.x, tileGridPosition.y);
        if (selectedItem != null)
        {
            rectTransform = selectedItem.GetComponent<RectTransform>();
            if (selectedItem.itemData.id == 2)
            {
                PlayerPrefs.SetInt("BatteryTaken", 1);
                Debug.Log("THIS WORKS");
            }
            else if (selectedItem.itemData.id == 3)
            {
                PlayerPrefs.SetInt("ToothpasteTaken", 1);
            }
            else if (selectedItem.itemData.id == 4)
            {
                PlayerPrefs.SetInt("KeyTaken", 1);
            }
    }
    }

    private void ItemIconDrag()
    {
        if (selectedItem != null)
        {
            rectTransform.position = Input.mousePosition;
        }
    }


    public void OnDestroy()
    {
        PlayerPrefs.SetFloat("BatteryTaken", 0);
        PlayerPrefs.SetFloat("ToothpasteTaken", 0);
        PlayerPrefs.SetFloat("HasBattery", 0);
        PlayerPrefs.SetFloat("HasToothpaste", 0);
        PlayerPrefs.SetInt("HasKey", 0);

    }
}
